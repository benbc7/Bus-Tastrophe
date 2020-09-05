using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using Rewired;

public class PlayerController : MonoBehaviour, MainControls.IDrivingControlsActions
{


    public PlayerInputs currentInput;

    private VehicleController vehicleController;
    //public Player player;

    private Rigidbody rb;
    private Vector3 startingLocation;
    private Quaternion startingRotation;

    private MainControls controls;

    void OnEnable()
    {
        if (controls == null)
        {
            controls = new MainControls();
            controls.DrivingControls.SetCallbacks(this);
        }
        controls.DrivingControls.Enable();
    }

    void OnDisble()
    {
        controls.DrivingControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        //player = ReInput.players.GetPlayer(0);
        vehicleController = GetComponent<VehicleController>();
        rb = GetComponent<Rigidbody>();
        startingLocation = transform.position;
        startingRotation = transform.rotation;

    }

    private void FixedUpdate()
    {
        //generatePlayerInputs();
        vehicleController.fixedUpdateVehicle(currentInput);
    }

    public void OnSteering(InputAction.CallbackContext context)
    {
        currentInput.steeringInput = context.ReadValue<float>();
    }

    public void OnGas(InputAction.CallbackContext context)
    {
        currentInput.accelInput = context.ReadValue<float>();
    }

    public void OnBrakes(InputAction.CallbackContext context)
    {
        currentInput.brakeInput = context.ReadValue<float>();
    }

	public void OnClutchButton (InputAction.CallbackContext context) {
        currentInput.clutchInput = context.ReadValue<float> ();
	}

	public void OnGearUpButton (InputAction.CallbackContext context) {
        currentInput.gearUpButtonDown = context.ReadValue<bool> ();
	}

	public void OnGearDownButton (InputAction.CallbackContext context) {
        currentInput.gearDownButtonDown = context.ReadValue<bool> ();
    }

	public void OnHandBrakeButton (InputAction.CallbackContext context) {
        currentInput.handBrakeButton = context.ReadValue<bool> ();
    }

	public void OnPitch (InputAction.CallbackContext context) {
        currentInput.pitchInput = context.ReadValue<float> ();
    }

	public void OnRoll (InputAction.CallbackContext context) {
        currentInput.rollInput = context.ReadValue<float> ();
    }

	public void OnYaw (InputAction.CallbackContext context) {
        currentInput.yawInput = context.ReadValue<float> ();
    }

	public void OnSwitchCameraButton (InputAction.CallbackContext context) {
        //currentInput = context.ReadValue<bool> ();
    }
	/*
private void generatePlayerInputs()
{
currentInput.accelInput = player.GetAxisRaw("Accelerate");
currentInput.brakeInput = player.GetAxisRaw("Brake");
currentInput.clutchInput = 0;
currentInput.steeringInput = player.GetAxisRaw("Steering");
currentInput.gearUpButtonDown = player.GetButtonDown("GearUp");
currentInput.gearDownButtonDown = player.GetButtonDown("GearDown");
currentInput.handBrakeButton = player.GetButton("Handbrake");
currentInput.pitchInput = player.GetAxis("Pitch");
currentInput.rollInput = player.GetAxis("Roll");
currentInput.yawInput = player.GetAxis("Steering");

vehicleController.fixedUpdateVehicle(currentInput);
}
// Update is called once per frame
void Update()
{
vehicleController.updateVehicle(currentInput);
if (player.GetButtonDown("Reset"))
{
print("player reset");
resetPlayer();
}

if (player.GetButtonDown("ToggleControlsText"))
{
print("player controller toggle ctrls");
GameManager.instance.toggleControlsDisplay();
}


}

public void resetPlayer()
{
vehicleController.resetVehicle(startingLocation, startingRotation);
}

*/
}
