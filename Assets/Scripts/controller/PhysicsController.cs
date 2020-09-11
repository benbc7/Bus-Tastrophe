using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    //Physics
    [SerializeField]
    private bool isGrounded;
    public Transform trans;
    public Rigidbody rb;
    public Vector3 centerOfMass;
    public Vector3 forwardPitchCenterOfMass;
    public Vector3 backwardPitchCenterOfMass;
    //air forces
    public int airYawSpeed;
    public int airRollSpeed;
    public int airPitchSpeed;
    //grounded forces
    public int groundedYawSpeed;
    public int groundedRollSpeed;
    public int groundedPitchSpeed;

    [Tooltip("Yaw torque is applied to the vehicle until it reaches this speed.")] 
    private int yawSpeedGovernerLimit = 100;
    // Start is called before the first frame update
    void Start()
    {
        trans = transform.parent;
        rb = trans.GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass;
    }
    public void fixedUpdatePhysics(PlayerInputs playerInputs, VehicleWheelMessage vwm)
    {
        Vector3 down = transform.TransformDirection(Vector3.down);
        isGrounded = Physics.Raycast(transform.position, down, 0.75f);
        if (isGrounded)
        {
            //multiply rb.velocity.magnitude by 3.6 to convert meter per second to km/h
            float yawSpeedGoverner = (yawSpeedGovernerLimit - (rb.velocity.magnitude * 3.6f)) / yawSpeedGovernerLimit;
            if (yawSpeedGoverner < 0)
                yawSpeedGoverner = 0;

            rb.AddRelativeTorque(Vector3.up * playerInputs.steeringInput * groundedYawSpeed * yawSpeedGoverner);
            rb.AddRelativeTorque(Vector3.back * playerInputs.rollInput * groundedRollSpeed);
            rb.AddRelativeTorque(Vector3.right * playerInputs.pitchInput * groundedPitchSpeed);
            if (playerInputs.pitchInput > 0)
            {
                //for nose wheelies/endos
                rb.centerOfMass = forwardPitchCenterOfMass;
                rb.AddRelativeTorque(Vector3.right * playerInputs.pitchInput * groundedPitchSpeed);
                rb.centerOfMass = centerOfMass;
            }
            else
            {
                //for wheelies
                rb.centerOfMass = backwardPitchCenterOfMass;
                rb.AddRelativeTorque(Vector3.right * playerInputs.pitchInput * groundedPitchSpeed);
                rb.centerOfMass = centerOfMass;
            }

            if (playerInputs.handBrakeButton)
                rb.AddRelativeTorque(Vector3.up * playerInputs.steeringInput * groundedYawSpeed * 2);
        }
        else //in the air
        {
            rb.AddRelativeTorque(Vector3.up * playerInputs.yawInput * airYawSpeed);
            rb.AddRelativeTorque(Vector3.back * playerInputs.rollInput * airRollSpeed);

            rb.AddRelativeTorque(Vector3.right * playerInputs.pitchInput * airPitchSpeed);
        }

        /*
            float yawSpeedGoverner = (100f - (rb.velocity.magnitude * 3.6f)) / 100;
            if (yawSpeedGoverner < 0)
                yawSpeedGoverner = 0;

            rb.AddRelativeTorque(Vector3.up * playerInputs.steeringInput * yawSpeed * yawSpeedGoverner);
            */
        //handbrake yaw power change
       


    }
    /*
    public void fixedUpdatePhysics(PlayerInputs playerInputs, VehicleWheelMessage vwm)
    {
        Vector3 down = transform.TransformDirection(Vector3.down);
        isGrounded = Physics.Raycast(transform.position, down, 0.25f);
        if (!isGrounded)
        {
            rb.AddForce(Vector3.up * airFloat * (60 * Time.fixedDeltaTime));
            rb.AddRelativeTorque(Vector3.up * playerInputs.steeringInput * (yawSpeed / 3));
            rb.AddRelativeTorque(Vector3.back * playerInputs.rollInput * rollSpeed);
            rb.AddRelativeTorque(Vector3.right * playerInputs.pitchInput * pitchSpeed);
        }
        else //ground control forces
        {
            float yawSpeedGoverner = (100f - (rb.velocity.magnitude * 3.6f))/100;
            if (yawSpeedGoverner < 0)
                yawSpeedGoverner = 0;

            rb.AddRelativeTorque(Vector3.up * playerInputs.steeringInput * yawSpeed * yawSpeedGoverner);
            rb.AddRelativeForce(Vector3.down * downforce);
        }
        //handbrake yaw power change
        if (playerInputs.handBrakeButton)
            rb.AddRelativeTorque(Vector3.up * playerInputs.steeringInput * yawSpeed * 2);

        if (!vwm.isRedlined)
        rb.AddRelativeForce(Vector3.forward * playerInputs.accelInput * pushSpeed);

    }
    */
}
