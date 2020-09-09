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
	public Slider musicVolumeSlider;
	public Slider effectsVolumeSlider;

	private SaveData saveData;

	private void Start () {
		settingsMenu.enabled = false;
		LoadSaveData ();
	}

	private void LoadSaveData () {
		if (SaveManager.instance != null) {
			saveData = SaveManager.instance.LoadDataFromDisk ();
			masterVolumeSlider.value = saveData.masterVolume;
			musicVolumeSlider.value = saveData.musicVolume;
			effectsVolumeSlider.value = saveData.soundEffectsVolume;
		}
	}

	public void OnPlayButton () {
		SaveManager.instance.SaveDataToDisk (saveData);
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
		saveData.masterVolume = volume;
		audioMixer.SetFloat ("MasterVolume", volume * 80 - 80);
	}

	public void OnMusicVolumeChanged (float volume) {
		saveData.musicVolume = volume;
		audioMixer.SetFloat ("MusicVolume", volume * 80 - 80);
	}

	public void OnEffectsVolumeChanged (float volume) {
		saveData.soundEffectsVolume = volume;
		audioMixer.SetFloat ("EffectsVolume", volume * 80 - 80);
	}

	public void OnQuitButton () {
		SaveManager.instance.SaveDataToDisk (saveData);
		Application.Quit ();

#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#endif
	}

	private void OnApplicationQuit () {
		SaveManager.instance.SaveDataToDisk (saveData);
	}
}