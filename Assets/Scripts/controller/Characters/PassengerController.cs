﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof (Animator))]
[RequireComponent (typeof (RagdollController))]
public class PassengerController : MonoBehaviour {

	public bool ragdollEnabled;

	private Animator animator;
	private RagdollController ragdollController;

	private void Awake () {
		animator = GetComponent<Animator> ();
		ragdollController = GetComponent<RagdollController> ();
	}

	private void Start () {
		if (ragdollEnabled)
			ActivateRagdoll ();
	}

	private void Update () {
		if (Mouse.current.leftButton.wasPressedThisFrame)
			animator.SetBool ("isRunning", true);
		if (Mouse.current.leftButton.wasReleasedThisFrame)
			animator.SetBool ("isRunning", false);

		if (Mouse.current.rightButton.wasPressedThisFrame) {
			ActivateRagdoll ();
		}
	}

	private void ActivateRagdoll () {
		AnimatorClipInfo[] clipInfos = animator.GetCurrentAnimatorClipInfo (0);
		Vector3 velocity = clipInfos [0].clip.averageSpeed;
		animator.enabled = false;
		velocity = transform.TransformDirection (velocity);
		ragdollController.SetRagdollActive (true, velocity);
	}
}