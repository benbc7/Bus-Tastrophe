﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public WheelCollider wheel;
    private RCC_Skidmarks skidmarks;
    private float currentSlip;
    public float startSlipValue = .35f;
    private int lastSkidmark = -1;
    public bool receivingPower = false;
    public bool receivingTurnInput = false;
    public bool rpmSensorWheel = false;
    public GameObject wheelShapePrefab;
    private GameObject wheelShape;
    [SerializeField]
    private AudioSource tireAudioSource;


    private void Start()
    {
        wheel = gameObject.GetComponent<WheelCollider>();
        skidmarks = GameObject.FindObjectOfType(typeof(RCC_Skidmarks)) as RCC_Skidmarks;
        tireAudioSource = GetComponent<AudioSource>();
    }

    public void initializeWheel(DriveType driveType)
    {
        //Debug.Log("Initializing wheel.");
        if (transform.localPosition.z > 0)
        {
            receivingTurnInput = true;
        }
        switch (driveType)
        {
            case DriveType.FrontWheelDrive:
                //front wheels
                if (transform.localPosition.z > 0)
                {
                    receivingPower = true;
                }
                break;
            case DriveType.RearWheelDrive:
                //rear wheels
                if (transform.localPosition.z < 0)
                {
                    receivingPower = true;
                }
                break;
            case DriveType.AllWheelDrive:
                receivingPower = true;
                break;
        }
    }
    public WheelVehicleMessage fixedUpdateWheelPhysics(PlayerInputs pi, VehicleWheelMessage vehicleWheelMessage)
    {
        WheelVehicleMessage wheelVehicleMessage = new WheelVehicleMessage();
        //turn
        if (receivingTurnInput)
        {
            wheel.steerAngle = vehicleWheelMessage.currentAngle;
            wheelVehicleMessage.frontWheelRpm = wheel.rpm;
        }
        else
        {
            wheelVehicleMessage.rearWheelRpm = wheel.rpm;
        }

        //power
        if (receivingPower && !vehicleWheelMessage.isRedlined)
        {
            wheel.motorTorque = vehicleWheelMessage.currentTorque;
        }
        else
            wheel.motorTorque = 0;

        //braking
        wheel.brakeTorque = vehicleWheelMessage.currentBrake;
        if (!receivingTurnInput && pi.handBrakeButton)
            wheel.brakeTorque = 10000f;
        calculateWheelMeshPositions();
        return wheelVehicleMessage;
    }

    public void calculateWheelMeshPositions()
    {
        Quaternion q;
        Vector3 p;
        wheel.GetWorldPose(out p, out q);
        // Assume that the only child of the wheelcollider is the wheel shape.
        Transform shapeTransform = wheel.transform.GetChild(0);
        shapeTransform.position = p;
        shapeTransform.rotation = q;
    }

    public void generateSkidmarks(Vector3 velocity, float magnitude)
    {

        // First, we are getting groundhit data.
        WheelHit GroundHit;
        wheel.GetGroundHit(out GroundHit);

        // Forward, sideways, and total slips.
        float wheelSlipAmountForward = Mathf.Abs(GroundHit.forwardSlip);
        float wheelSlipAmountSideways = Mathf.Abs(GroundHit.sidewaysSlip);

        currentSlip = Mathf.Lerp(currentSlip, (wheelSlipAmountSideways + wheelSlipAmountForward), Time.fixedDeltaTime * 3f) / 1f;

        // If scene has skidmarks manager...
        if (skidmarks)
        {
            // If slips are bigger than target value...
            if (wheelSlipAmountSideways + wheelSlipAmountForward > startSlipValue)
            {

                Vector3 skidPoint = GroundHit.point + 2f * (velocity) * Time.deltaTime;

                if (magnitude > 1f)
                    lastSkidmark = skidmarks.AddSkidMark(skidPoint, GroundHit.normal, currentSlip, lastSkidmark);
                else
                    lastSkidmark = -1;

            }
            else
            {
                lastSkidmark = -1;
            }

        }

        tireAudio();

    }

    private void tireAudio() {
        if (currentSlip > startSlipValue) {
            if (!tireAudioSource.isPlaying)
                tireAudioSource.Play();
            tireAudioSource.volume = Mathf.Lerp(0f, 0.5f, currentSlip - 0);
            tireAudioSource.pitch = Mathf.Lerp(1f, .8f, tireAudioSource.volume);
        }
        else{
        tireAudioSource.volume = 0f;
            if (tireAudioSource.volume <= .05f && tireAudioSource.isPlaying)
            tireAudioSource.Stop();
        }
    }
}


public enum DriveType
{
    FrontWheelDrive, RearWheelDrive, AllWheelDrive
}

public class WheelVehicleMessage
{
    public float frontWheelRpm;
    public float rearWheelRpm;

}