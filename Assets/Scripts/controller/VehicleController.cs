using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleController : MonoBehaviour
{
    VehicleAudioController audioController;
    VehicleUIController vehicleUIController;
    private PhysicsController physicsController;
    private BusPassengerTracker busPassengerTracker;

    private Rigidbody rb;


    public VehicleWheelMessage currentVehicle;

    //currents
    [SerializeField]
    private int currentGear;
    [SerializeField]
    private float currentSpeed;

    private float currentFlywheelVelocity;
    [SerializeField]
    private float currentTorque;
    [SerializeField]
    private float currentEngineRpm;
    [SerializeField]
    private float currentBrake;
    [SerializeField]
    public float currentSteeringAngle = 0f;

    public float currentReverseAutoBrakeInput;
    public float currentReverseAutoAccelInput;

    
    private bool isShifting;
    [SerializeField]
    private float currentFrontWheelRpm;
    [SerializeField]
    private float currentRearWheelRpm;

    //Maximums
    public bool isAutomatic = true;
    public float maxTorque = 3000f;
    public float maxEngineRpm = 7000f;
    public float maxBrakeTorque = 3000f;
    public float maxHandbrakeTorque = 10000f;
    public float maxSteeringAngle = 30f;

    //Steering
    public float steerSmooth = 0.1f;
    private float baseSteerSmooth = 0.1f;
    private float steerVelocity = 0.1f;
    private float wheelDiameter = 1f;

    //Engine
    public bool isRedlined = false;
    public float engineVelocity = 0f;
    public float engineSmooth = 0.3f;
    public static float startSlipValue = .35f;

    //Wheels
    private WheelCollider[] wheelColliders;
    private WheelController[] wheelControllers;


    //Transmission
    [Tooltip("The vehicle's drive type: rear-wheels drive, front-wheels drive or all-wheels drive.")]
    public DriveType driveType;
    public Gear[] gears;
    public bool isReverse;
    public static float shiftTime = 0.1f;

    //Wheel Physics Sub-steps
    [Tooltip("The vehicle's speed when the physics engine can use different amount of sub-steps (in m/s).")]
    private float criticalSpeed = 5f;
    [Tooltip("Simulation sub-steps when the speed is above critical.")]
    private static int stepsBelow = 5;
    [Tooltip("Simulation sub-steps when the speed is below critical.")]
    private static int stepsAbove = 1;

    //Visual
    [Tooltip("If you need the visual wheels to be attached automatically, drag the wheel shape here.")]
    public GameObject wheelShape;

    // Start is called before the first frame update
    void Start()
    {
        audioController = GetComponentInChildren<VehicleAudioController>();
        physicsController = GetComponentInChildren<PhysicsController>();
        vehicleUIController = GetComponentInChildren<VehicleUIController>();
        busPassengerTracker = GetComponentInChildren<BusPassengerTracker>();
        rb = GetComponent<Rigidbody>();
        baseSteerSmooth = steerSmooth;
        Mathf.Clamp(currentGear, 0, 5);
        currentGear = 1;

        wheelControllers = GetComponentsInChildren<WheelController>();

        foreach (WheelController wheelController in wheelControllers)
        {
            //print("Wheel " + wheelController.gameObject.name);
            wheelController.initializeWheel(driveType);
            // Create wheel shapes only when needed.
            if (wheelShape != null)
            {
                var ws = Instantiate(wheelShape);
                ws.transform.parent = wheelController.transform;
                ws.transform.localPosition = Vector3.zero;
            }
        }

        initializeGears();
    }

    public void initializeGears()
    {
        foreach (Gear gear in gears)
        {
            //kmh CONVERT TO meters per second 
            //1 k/h = 3.6 m/s
            //example: second gear has a max RPM of 1k
            float topMeterPerSecond = gear.topSpeed / 3.6f;
            float topMeterPerMinute = topMeterPerSecond * 60f;

            gear.topWheelRpm = topMeterPerMinute / wheelDiameter;
        }
    }

    public void resetVehicle(Vector3 resetPosition, Quaternion resetLocation)
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = resetPosition;
        transform.rotation = resetLocation;
        StartCoroutine(changeGear(1));
    }

    public void updateVehicle(PlayerInputs pi)
    {
        

        vehicleUIController.updateUI(currentSpeed, currentEngineRpm);
        foreach (WheelController wheelController in wheelControllers)
        {
            wheelController.generateSkidmarks(rb.velocity, rb.velocity.magnitude);
            wheelController.calculateWheelMeshPositions();
        }

        audioController.updateVehicleAudio(currentEngineRpm, pi.accelInput);
    }

    public void fixedUpdateVehicle(PlayerInputs pi)
    {
      
        if (!isShifting)
        {
            if (isAutomatic)
                fixedUpdateAutomatic(pi);
            else
                fixedUpdateManual(pi);
        }

        VehicleWheelMessage vehicleWheelMessage = calculateVehiclePhysics(pi);
        ApplyWheelPhysics(pi, vehicleWheelMessage);
        physicsController.fixedUpdatePhysics(pi, vehicleWheelMessage);
    }
    private void fixedUpdateAutomatic(PlayerInputs pi)
    {
        if (currentGear < gears.Length - 1 && currentEngineRpm >= maxEngineRpm * 0.8f && currentGear != 0)
            StartCoroutine(changeGear(currentGear += 1));

        else if (currentGear > 1 && currentEngineRpm <= 4500f)
            StartCoroutine(changeGear(currentGear -= 1));

        //put it in reverse!
        if (rb.velocity.magnitude <= 0.1f && pi.brakeInput > 0.1f && currentGear != 0)
        {
            StartCoroutine(changeGear(0));
        }

        if (currentGear == 0)
        {
            if (rb.velocity.magnitude <= 0.1f && (pi.accelInput > pi.brakeInput))
                StartCoroutine(changeGear(1));
            currentReverseAutoAccelInput = pi.brakeInput;
            currentReverseAutoBrakeInput = pi.accelInput;
        }

    }
    private void fixedUpdateManual(PlayerInputs pi)
    {
        if (currentGear < gears.Length - 1 && pi.gearUpButtonDown)
            StartCoroutine(changeGear(currentGear += 1));

        else if (currentGear > 0 && pi.gearDownButtonDown)
            StartCoroutine(changeGear(currentGear -= 1));
    }

    private void ApplyWheelPhysics(PlayerInputs pi, VehicleWheelMessage vehicleWheelMessage)
    {
        currentFrontWheelRpm = 0;
        currentRearWheelRpm = 0;
        foreach (WheelController wheelController in wheelControllers)
        {
            WheelVehicleMessage wvm = wheelController.fixedUpdateWheelPhysics(pi, vehicleWheelMessage);
            currentFrontWheelRpm += wvm.frontWheelRpm;
            currentRearWheelRpm += wvm.rearWheelRpm;
            wheelController.wheel.ConfigureVehicleSubsteps(criticalSpeed, stepsBelow, stepsAbove);
        }
        currentFrontWheelRpm /= 2;
        currentRearWheelRpm /= 2;
    }

    private IEnumerator changeGear(int newGear)
    {
        isShifting = true;
        yield return new WaitForSeconds(shiftTime);
         currentGear = newGear;
        vehicleUIController.updateGearUI(currentGear, currentEngineRpm);
        isShifting = false;
    }

    public void updatePassengerCount(int passengerCount)
    {
        vehicleUIController.updatePassengerCountUI(passengerCount);
    }


    private VehicleWheelMessage calculateVehiclePhysics(PlayerInputs pi)
    {
        //STOP GO TURN
        //meters per second >> kph
        currentSpeed = rb.velocity.magnitude * 3.6f;
        if (isAutomatic && currentGear == 0)
        {
            calculateEngineOutputArcade(currentReverseAutoAccelInput);
            calculateBrakeOutput(currentReverseAutoBrakeInput);
        }
        else
        {
            calculateEngineOutputArcade(pi.accelInput);
            calculateBrakeOutput(pi.brakeInput);
        }
        calculateSteeringAngle(pi.steeringInput);
        return generateVehicleMessage();
    }

    private void calculateEngineOutputArcade(float accelInput)
    {
        currentSpeed = rb.velocity.magnitude * 3.6f;
        float speedPercentageToGearMax = currentSpeed / gears[currentGear].topSpeed;
        if (speedPercentageToGearMax > 1)
        {
            isRedlined = true;
        }
        else
            isRedlined = false;

        float gearEvaluation = (gears[currentGear].torqueCurve.Evaluate((speedPercentageToGearMax)));
        currentTorque = accelInput * (maxTorque * gearEvaluation);
        currentEngineRpm = (speedPercentageToGearMax * maxEngineRpm) + 500;
    }

    /*
    private void calculateEngineOutputSim(float accelInput)
    {
        currentSpeed = rb.velocity.magnitude * 3.6f;
        //0-1  value

        float speedPercentageToGearMax = currentSpeed / gears[currentGear].topSpeed;
        float speedPercentageToGearMaxWheel = currentRearWheelRpm / gears[currentGear].topWheelRpm;
        float averageSpeedPercentage = ((speedPercentageToGearMax * 5) + speedPercentageToGearMaxWheel) / 2;
        if (averageSpeedPercentage > 1)
        {
            isRedlined = true;
        }
        else
            isRedlined = false;
        
        float gearEvaluation = (gears[currentGear].torqueCurve.Evaluate(averageSpeedPercentage));
        //currentFlywheelVelocity = Mathf.SmoothDamp(currentFlywheelVelocity, gearEvaluation, ref engineVelocity, engineSmooth);


        currentTorque = accelInput * (maxTorque * gearEvaluation);
        currentEngineRpm = (averageSpeedPercentage * maxEngineRpm) + 500;
    }
    */

    private void calculateBrakeOutput(float brakeInput)
    {
        currentBrake = brakeInput * maxBrakeTorque;
    }

    private void calculateSteeringAngle(float steeringInput)
    {
        float inputAngle = maxSteeringAngle * steeringInput;
        steerSmooth = baseSteerSmooth + (currentSpeed * 0.0008f);
        currentSteeringAngle = Mathf.SmoothDamp(currentSteeringAngle, inputAngle, ref steerVelocity, steerSmooth);
    }

    private VehicleWheelMessage generateVehicleMessage()
    {

        VehicleWheelMessage vwm = new VehicleWheelMessage();
        vwm.currentSpeed = currentSpeed;
        vwm.currentBrake = currentBrake;
        vwm.currentAngle = currentSteeringAngle;
        if (currentRearWheelRpm > gears[currentGear].topWheelRpm)
            vwm.currentTorque = 0;
        else
            vwm.currentTorque = currentTorque;
        vwm.isRedlined = isRedlined;
        return vwm;
    }
}
