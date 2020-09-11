using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToOriginalPosition : MonoBehaviour {

	private Vector3 originalPosition;
	private Quaternion originalRotation;

	private void Start () {
		originalPosition = transform.position;
		originalRotation = transform.rotation;
		LevelManager.instance.onLevelResetEvent += OnLevelReset;
	}

	private void OnDisable () {
		LevelManager.instance.onLevelResetEvent -= OnLevelReset;
	}

	public void OnLevelReset () {
		transform.position = originalPosition;
		transform.rotation = originalRotation;
		GetComponent<Rigidbody> ().velocity = Vector3.zero;
	}
}