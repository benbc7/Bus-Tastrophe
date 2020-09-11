using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour, MainControls.ICameraControlsActions {

	public float smoothing = 6f;
	public Transform lookAtTarget;
	public Transform positionTarget;

	[Header ("Free Look Settings")]
	public float sensitivity = 75f;
	public float verticalAngleLimit = 70f;
	public float moveSpeed = 5f;
	public float fastMoveSpeed = 10f;

	private float verticalDegrees = 0f;
	private float horizontalDegrees = 0f;
	private Quaternion currentRotation;
	private Quaternion targetRotation;
	private Vector3 smoothRotateVelocity;
	private Vector3 currentPosition;
	private Vector3 targetPosition;
	private Vector3 smoothMoveVelocity;
	private float smoothTime = 0.2f;

	private bool isPaused;

	private MainControls controls;
	private InputAxis input = new InputAxis ();

	private void Start () {
		LevelManager.instance.OnPauseGameEvent += OnPauseGame;
	}

	private void OnEnable () {
		if (controls == null) {
			controls = new MainControls ();
			controls.CameraControls.SetCallbacks (this);
		}
		controls.CameraControls.Enable ();
	}

	private void OnDisable () {
		LevelManager.instance.OnPauseGameEvent -= OnPauseGame;
		controls.CameraControls.Disable ();
	}

	public void OnPauseGame (bool isPaused) {
		this.isPaused = isPaused;
	}

	private void FixedUpdate () {
		if (!isPaused)
			FollowCarCameraUpdate ();
	}

	private void Update () {
		if (isPaused && LevelManager.instance.isFreeLookMode) {
			FreeCameraLook ();
			FreeCameraMove ();
		}
	}

	private void FollowCarCameraUpdate () {
		transform.position = Vector3.Lerp (transform.position, positionTarget.position, Time.deltaTime * smoothing);
		transform.LookAt (lookAtTarget);
	}

	private void FreeCameraLook () {
		verticalDegrees = transform.eulerAngles.x;
		horizontalDegrees = transform.eulerAngles.y;

		verticalDegrees -= input.lookAxis.y * sensitivity * Time.unscaledDeltaTime * 50f;
		horizontalDegrees += input.lookAxis.x * sensitivity * Time.unscaledDeltaTime * 50f;

		verticalDegrees = ClampAngle (verticalDegrees, -verticalAngleLimit, verticalAngleLimit);
		targetRotation = Quaternion.Euler (new Vector3 (verticalDegrees, horizontalDegrees, 0));
		currentRotation = transform.rotation;

		transform.rotation = Quaternion.Lerp (
			currentRotation,
			targetRotation,
			smoothing * Time.unscaledDeltaTime);
	}

	private void FreeCameraMove () {
		currentPosition = transform.position;
		Vector3 move = new Vector3 (
			input.moveAxis.x,
			input.upMovement + input.downMovement,
			input.moveAxis.y);
		move *= (!input.fastMovement) ? moveSpeed : fastMoveSpeed;
		move = transform.TransformDirection (move);
		targetPosition = currentPosition + move * Time.unscaledDeltaTime * 50f;

		transform.position = Vector3.Lerp (
			currentPosition,
			targetPosition,
			smoothing * Time.unscaledDeltaTime);
	}

	#region ICameraControlsActions

	public void OnCameraLook (InputAction.CallbackContext context) {
		if (LevelManager.instance.isFreeLookMode) {
			input.lookAxis = context.ReadValue<Vector2> ();
		}
	}

	public void OnCameraMove (InputAction.CallbackContext context) {
		if (LevelManager.instance.isFreeLookMode) {
			input.moveAxis = context.ReadValue<Vector2> ();
		}
	}

	public void OnUpButton (InputAction.CallbackContext context) {
		if (LevelManager.instance.isFreeLookMode) {
			if (context.started) {
				input.upMovement = 1f;
			} else if (context.canceled) {
				input.upMovement = 0f;
			}
		}
	}

	public void OnDownButton (InputAction.CallbackContext context) {
		if (LevelManager.instance.isFreeLookMode) {
			if (context.started) {
				input.downMovement = -1f;
			} else if (context.canceled) {
				input.downMovement = 0f;
			}
		}
	}

	public void OnMoveFasterButton (InputAction.CallbackContext context) {
		if (LevelManager.instance.isFreeLookMode) {
			if (context.started)
				input.fastMovement = true;
			else if (context.canceled)
				input.fastMovement = false;
		}
	}

	public void OnBackButton (InputAction.CallbackContext context) {
		if (LevelManager.instance.isFreeLookMode) {
			LevelManager.instance.FreeLookCameraEnabled (false);
		}
	}

	public void OnScreenshotButton (InputAction.CallbackContext context) {
		if (LevelManager.instance.isFreeLookMode) {
			if (context.started)
				Time.timeScale = 1f;
			else if (context.canceled)
				Time.timeScale = 0f;
		}
	}

	#endregion

	private void OnValidate () {
		if (verticalAngleLimit > 90f) {
			verticalAngleLimit = 90f;
		}
	}

	private static float ClampAngle (float angle, float min, float max) {
		if (angle > 180)
			return Mathf.Clamp (angle, min + 360, max + 360);
		else
			return Mathf.Clamp (angle, min, max);
	}

	private class InputAxis {
		public Vector2 lookAxis;
		public Vector2 moveAxis = new Vector2 ();
		public float upMovement;
		public float downMovement;
		public bool fastMovement;
	}
}
