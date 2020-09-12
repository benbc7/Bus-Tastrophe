using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuManager : MonoBehaviour {

	public static PauseMenuManager instance;

	public GameObject pauseMenuCanvas;
	public Selectable firstButton;

	private bool isPaused;
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
			pauseMenuCanvas.SetActive (isPaused);
		}
	}

	public void OnQuitButton () {
		SceneManager.LoadScene ("mainmenu");
	}

	public void OnPauseButton () {
		LevelManager.instance.PauseGame ();
		isPaused = !isPaused;
		pauseMenuCanvas.SetActive (isPaused);
		firstButton.Select ();
	}

	public void OnFreeLookCameraButton () {
		isFreeLookMode = true;
		pauseMenuCanvas.SetActive (false);
		LevelManager.instance.FreeLookCameraEnabled (true);
	}
}
