using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public static LevelManager instance;

	public delegate void OnLevelReset ();
	public event OnLevelReset onLevelResetEvent;

	public delegate void OnPauseGame (bool isPaused);
	public event OnPauseGame OnPauseGameEvent;

	private bool isPaused;
	public bool isFreeLookMode { get; private set; }

	private List<GameObject> objectsToDisableOnPause;

	private void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	public void PauseGame () {
		isPaused = !isPaused;
		DisableObjectsOnPause ();

		if (!isPaused) {
			FreeLookCameraEnabled (false);
		}

		if (OnPauseGameEvent != null) {
			OnPauseGameEvent (isPaused);
			Time.timeScale = isPaused ? 0f : 1f;
			//Cursor.lockState = isPaused ? CursorLockMode.None : CursorLockMode.Locked;
			//Cursor.visible = isPaused ? true : false;
		}
	}

	private void DisableObjectsOnPause () {
		if (objectsToDisableOnPause == null) {
			objectsToDisableOnPause = new List<GameObject> ();
			foreach (DisableOnPauseGame d in FindObjectsOfType<DisableOnPauseGame> (true)) {
				objectsToDisableOnPause.Add (d.gameObject);
			}
		}

		foreach (GameObject go in objectsToDisableOnPause) {
			go.SetActive (!isPaused);
		}
	}

	public void FreeLookCameraEnabled (bool isEnabled) {
		isFreeLookMode = isEnabled;
		//Cursor.lockState = !isEnabled ? CursorLockMode.None : CursorLockMode.Locked;
		//Cursor.visible = !isEnabled ? true : false;
	}

	public void ResetLevel () {
		if (onLevelResetEvent != null)
			onLevelResetEvent ();
	}
}