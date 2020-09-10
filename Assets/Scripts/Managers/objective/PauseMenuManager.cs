using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour {

    public static PauseMenuManager instance;

    public GameObject pauseMenuCanvas;

    private bool isPaused;

	public void returnToMainMenu () {
        print ("returning to main menu");
        SceneManager.LoadScene ("mainmenu");
    }

    public void OnPauseGame () {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f;
        //pauseMenuCanvas.SetActive (isPaused);
	}
}
