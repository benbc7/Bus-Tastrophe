using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

[RequireComponent (typeof (TrackSelectManager))]
public class MainMenuManager : MonoBehaviour, MainControls.IMenuControlsActions {

	public Animator cameraAnimator;
	public AudioMixer audioMixer;
	public Canvas settingsMenu;
	public Canvas levelSelectMenu;

	[Header ("UI Elements")]
	public CanvasUtility settingsCanvasUtility;
	public CanvasUtility levelSelectCanvasUtility;
	public Button playButton;
	public Slider masterVolumeSlider;
	public Slider musicVolumeSlider;
	public Slider effectsVolumeSlider;
	public Selectable levelSelectIndicator;
	public Button loadLevelButton;
	public Button levelSelectBackButton;
	public Image loadingBarImage;

	private TrackSelectManager trackManager;
	private SaveData saveData;
	private bool isSelectingLevel;
	private bool isLoadingScene;
	private MainControls controls;

	private void OnEnable () {
		if (controls == null) {
			controls = new MainControls ();
			controls.MenuControls.SetCallbacks (this);
		}
		controls.MenuControls.Enable ();
	}

	private void OnDisable () {
		controls.MenuControls.Disable ();
	}

	private void Start () {
		trackManager = GetComponent<TrackSelectManager> ();
		//settingsMenu.enabled = false;
		//levelSelectMenu.enabled = false;
		settingsCanvasUtility.SetRaycastTargetsEnabled (false);
		levelSelectCanvasUtility.SetRaycastTargetsEnabled (false);
		LoadSaveData ();
		if (loadingBarImage != null)
			loadingBarImage.enabled = false;
	}

	private void LoadSaveData () {
		if (SaveManager.instance != null) {
			saveData = SaveManager.instance.LoadDataFromDisk ();
			masterVolumeSlider.value = saveData.masterVolume;
			musicVolumeSlider.value = saveData.musicVolume;
			effectsVolumeSlider.value = saveData.soundEffectsVolume;
		}
	}

	public void OnStartLevelButton () {
		TrackAsset trackAsset = trackManager.GetSelectedTrack ();
		StartCoroutine (LoadLevelAsync (trackAsset.sceneBuildIndex));
	}

	private IEnumerator LoadLevelAsync (int sceneIndex) {
		if (SceneManager.GetSceneByBuildIndex (sceneIndex) == null) {
			throw new System.Exception ("The Scene you tried to load (index: " + sceneIndex + ") isn't in the build settings.");
#pragma warning disable CS0162 // Unreachable code detected
			yield break;
#pragma warning restore CS0162 // Unreachable code detected
		}

		if (loadingBarImage != null) {
			loadingBarImage.enabled = true;
			loadingBarImage.fillAmount = 0f;
		}
		isLoadingScene = true;
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync (sceneIndex);
		while (!asyncLoad.isDone) {
			if (loadingBarImage != null)
				loadingBarImage.fillAmount = asyncLoad.progress;
			yield return null;
		}
	}

	#region UI Functions

	public void OnPlayButton () {
		//levelSelectMenu.enabled = true;
		levelSelectCanvasUtility.SetRaycastTargetsEnabled (true);
		isSelectingLevel = true;
		cameraAnimator.SetTrigger ("levelSelectScreen");
		levelSelectIndicator.Select ();
	}

	public void OnSettingsButton () {
		//settingsMenu.enabled = true;
		settingsCanvasUtility.SetRaycastTargetsEnabled (true);
		cameraAnimator.SetTrigger ("settingsScreen");
		masterVolumeSlider.Select ();
	}

	public void OnBackButton () {
		//settingsMenu.enabled = false;
		//levelSelectMenu.enabled = false;
		settingsCanvasUtility.SetRaycastTargetsEnabled (false);
		levelSelectCanvasUtility.SetRaycastTargetsEnabled (false);
		cameraAnimator.SetTrigger ("backToMain");
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

	#endregion

	private void OnApplicationQuit () {
		SaveManager.instance.SaveDataToDisk (saveData);
	}

	public void OnMove (InputAction.CallbackContext context) {
		if (isSelectingLevel && !isLoadingScene && EventSystem.current.currentSelectedGameObject == levelSelectIndicator.gameObject) {
			float xInput = context.ReadValue<Vector2> ().x;
			if (context.performed) {
				if (xInput != 0f) {
					if (xInput > 0.95f) {
						trackManager.NextTrack ();
					} else if (xInput < -0.95f) {
						trackManager.PreviousTrack ();
					}
				}
			}
		}
	}

	public void OnConfirm (InputAction.CallbackContext context) {
		//throw new System.NotImplementedException ();
	}

	public void OnBack (InputAction.CallbackContext context) {
		if (context.started)
			OnBackButton ();
	}
}