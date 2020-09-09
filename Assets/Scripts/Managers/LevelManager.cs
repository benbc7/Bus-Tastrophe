using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public static LevelManager instance;

	public delegate void OnLevelReset ();
	public event OnLevelReset onLevelResetEvent;

	private void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
	}

	public void ResetLevel () {
		if (onLevelResetEvent != null)
			onLevelResetEvent ();
	}
}