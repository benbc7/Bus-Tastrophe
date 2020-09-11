using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using System;
using System.Collections.ObjectModel;

[CustomEditor (typeof (TrackAsset))]
public class TrackAssetEditor : Editor {

	private TrackAsset trackAsset;
	private bool advancedFoldout;
	private bool dictionaryFoldout;

	public override void OnInspectorGUI () {
		base.OnInspectorGUI ();

		trackAsset = (TrackAsset)target;

		advancedFoldout = EditorGUILayout.BeginFoldoutHeaderGroup (advancedFoldout, "Advanced Options");
		if (advancedFoldout) {
			if (GUILayout.Button ("Clear Dictionary")) {
				trackAsset.ClearDictionary ();
			}

			dictionaryFoldout = EditorGUILayout.Foldout (dictionaryFoldout, "Dictionary", true);
			if (dictionaryFoldout) {
				DrawDictionary ();
			}
		}
		EditorGUILayout.EndFoldoutHeaderGroup ();
	}

	private void DrawDictionary () {
		Dictionary<Guid, TrackAsset>.KeyCollection keys = TrackAsset.trackAssets.Keys;
		foreach (Guid guid in keys) {
			EditorGUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			EditorGUILayout.LabelField (TrackAsset.trackAssets [guid].trackName + ": ");
			EditorGUILayout.LabelField (guid.ToString ());
			EditorGUILayout.EndHorizontal ();
		}
	}
}