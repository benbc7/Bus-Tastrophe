using UnityEngine;
using UnityEditor;
using UnityEditor.Experimental.TerrainAPI;

[CustomEditor (typeof(AudioManager))]
public class AudioManagerEditor : Editor {

	public override void OnInspectorGUI () {
		base.OnInspectorGUI ();
	}
}