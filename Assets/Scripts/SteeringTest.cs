using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SteeringTest : MonoBehaviour, MainControls.IDrivingControlsActions {

	private MainControls controls;

	[Header ("Test Values")]
	public float steeringAxis;
	public float fixedUpdateSteeringAxis;

	private void Awake () {
		
	}

	private void FixedUpdate () {
		fixedUpdateSteeringAxis = steeringAxis;
	}

	public void OnSteeringInput (float axis) {
		steeringAxis = axis;
	}

	public void OnEnable () {
		if (controls == null) {
			controls = new MainControls ();
			controls.DrivingControls.SetCallbacks (this);
		}

		controls.DrivingControls.Enable ();
	}

	public void OnDisable () {
		controls.DrivingControls.Disable ();
	}

	public void OnSteering (InputAction.CallbackContext context) {

		steeringAxis = context.ReadValue<float> ();
	}

	public void OnGas (InputAction.CallbackContext context) {
	}

	public void OnBrakes (InputAction.CallbackContext context) {
	}
}