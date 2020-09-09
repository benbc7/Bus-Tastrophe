using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof (Canvas))]
public class CanvasUtility : MonoBehaviour {

	private Selectable[] selectables;

	private void Awake () {
		selectables = GetComponentsInChildren<Selectable> ();
	}

	public void SetRaycastTargetsEnabled (bool enabled) {
		foreach (Selectable s in selectables) {
			s.interactable = enabled;
		}
	}
}