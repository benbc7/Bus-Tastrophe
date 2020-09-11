using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour {

	public static PauseMenuManager instance;

	public GameObject pauseMenuCanvas;

	private bool isFreeLookMode;

	private void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (this);
		}

		pauseMenuCanvas.SetActive (false);
	}

	private void Update () {
		if (isFreeLookMode && !LevelManager.instance.isFreeLookMode) {
			isFreeLookMode = false;
			pauseMenuCanvas.SetActive (true);
		}
	}

	public void OnQuitButton () {
		print ("returning to main menu");
		SceneManager.LoadScene ("mainmenu");
	}

	public void OnPauseButton () {
		LevelManager.instance.PauseGame ();
		pauseMenuCanvas.SetActive (!pauseMenuCanvas.activeSelf);
	}

	public void OnFreeLookCameraButton () {
		isFreeLookMode = true;
		pauseMenuCanvas.SetActive (false);
		LevelManager.instance.FreeLookCameraEnabled (true);
	}
}
