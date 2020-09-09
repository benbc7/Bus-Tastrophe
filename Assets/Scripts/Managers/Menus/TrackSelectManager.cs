using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof (MainMenuManager))]
public class TrackSelectManager : MonoBehaviour {

	public TrackAsset[] trackAssets;
	public GameObject trackPreviewCamera;
	public Transform trackPreviewParent;
	public float trackPreviewGap = 3f;

	[Header ("UI")]
	public Text trackNameText;
	public Text bestTimeText;

	private MainMenuManager menuManager;
	private Transform[] trackPreviewObjects;
	private int currentTrackIndex = 0;

	private Vector3 targetPosition;
	private float smoothTime = 0.2f;
	private Vector3 smoothVelocity;

	private void Start () {
		menuManager = GetComponent<MainMenuManager> ();
		targetPosition = trackPreviewParent.localPosition;
		ShowTrackPreview ();
	}

	private void Update () {
		if (trackPreviewParent.localPosition != targetPosition) {
			Vector3 newPosition = Vector3.SmoothDamp (
				trackPreviewParent.localPosition,
				targetPosition,
				ref smoothVelocity,
				smoothTime);
			trackPreviewParent.localPosition = newPosition;
		}
	}

	public void ShowTrackPreview () {
		trackPreviewObjects = new Transform [trackAssets.Length];
		for (int i = 0; i < trackAssets.Length; i++) {
			Transform trackPreview = Instantiate (
				trackAssets[i].trackPreviewPrefab, 
				trackPreviewParent).transform;
			trackPreview.localPosition = new Vector3 (i * trackPreviewGap, 0f, 0f);
			trackPreviewObjects [i] = trackPreview;
		}

		UpdateTextValues ();
	}

	private void ChangePreviewTrack () {
		targetPosition = new Vector3 (
			currentTrackIndex * -trackPreviewGap,
			trackPreviewParent.localPosition.y,
			trackPreviewParent.localPosition.z);
		UpdateTextValues ();
	}

	private void UpdateTextValues () {
		if (trackAssets [currentTrackIndex] != null) {
			trackNameText.text = trackAssets [currentTrackIndex].trackName;
			float timeInSeconds = trackAssets [currentTrackIndex].defaultBestTimeInSeconds;
			int minutes = Mathf.FloorToInt (timeInSeconds / 60f);
			int seconds = (int)(timeInSeconds % 60f);
			bestTimeText.text = minutes.ToString ("d2") + ":" + seconds.ToString("d2") + ":" + "00";
		}
	}

	public void NextTrack () {
		currentTrackIndex++;
		if (currentTrackIndex >= trackAssets.Length)
			currentTrackIndex = 0;
		ChangePreviewTrack ();
	}

	public void PreviousTrack () {
		currentTrackIndex--;
		if (currentTrackIndex < 0)
			currentTrackIndex = trackAssets.Length - 1;
		ChangePreviewTrack ();
	}

	public TrackAsset GetSelectedTrack () {
		return trackAssets [currentTrackIndex];
	}
}