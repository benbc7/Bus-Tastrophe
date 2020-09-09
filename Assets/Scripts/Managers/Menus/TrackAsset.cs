using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName ="Scriptable Objects/Track Asset")]
public class TrackAsset : ScriptableObject {

	public GameObject trackPreviewPrefab;
	public int sceneBuildIndex;

	[Header ("Track Info")]
	public string trackName;
	public float defaultBestTimeInSeconds;

	[HideInInspector] public float bestTimeInSeconds;
	[HideInInspector] public int trackID;
}