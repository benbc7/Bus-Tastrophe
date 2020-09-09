using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour {
	public Vector3 rotationsPerSecond;

	private void Update () {
		if (rotationsPerSecond != Vector3.zero) {
			transform.Rotate (rotationsPerSecond * Time.deltaTime);
		}
	}
}
