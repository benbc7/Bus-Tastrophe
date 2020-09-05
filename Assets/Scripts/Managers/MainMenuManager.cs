using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	public Canvas settingsMenu;
	public Animator cameraAnimator;
	public AudioMixer audioMixer;

	[Header ("Navigation")]
	public Button playButton;
	public Slider masterVolumeSlider;

	private void Start () {
		settingsMenu.enabled = false;
	}

	public void OnPlayButton () {
		SceneManager.LoadScene (1);
	}

	public void OnSettingsButton () {
		settingsMenu.enabled = true;
		cameraAnimator.SetBool ("settingsScreen", true);
		masterVolumeSlider.Select ();
	}

	public void OnBackButton () {
		settingsMenu.enabled = false;
		cameraAnimator.SetBool ("settingsScreen", false);
		playButton.Select ();
	}

	public void OnMasterVolumeChanged (float volume) {
		audioMixer.SetFloat ("MasterVolume", volume * 80 - 80);
	}

	public void OnMusicVolumeChanged (float volume) {
		audioMixer.SetFloat ("MusicVolume", volume * 80 - 80);
	}

	public void OnEffectsVolumeChanged (float volume) {
		audioMixer.SetFloat ("EffectsVolume", volume * 80 - 80);
	}

	public void OnQuitButton () {
		Application.Quit ();

#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#endif
	}
}