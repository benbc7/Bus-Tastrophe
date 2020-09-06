using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour {

	[HideInInspector]
	public Rigidbody[] rigidBodies;

	private CharacterJoint[] joints;

	public float totalMass;
	public CollisionDetectionMode collisionMode;

	private CollisionDetectionMode currentCollisionMode;

	private void Awake () {
		joints = GetComponentsInChildren<CharacterJoint> ();
		foreach (CharacterJoint joint in joints) {
			joint.enableProjection = true;
		}
	}

	public void GetAllRigidbodies () {
		rigidBodies = GetComponentsInChildren<Rigidbody> ();
	}

	private void SetRagdollMass () {
		if (rigidBodies == null || rigidBodies.Length == 0) {
			GetAllRigidbodies ();
		}

		if (rigidBodies != null && rigidBodies.Length != 0) {
			float currentMass = 0f;
			foreach (Rigidbody rb in rigidBodies) {
				currentMass += rb.mass;
			}

			float ratio = totalMass / currentMass;
			foreach (Rigidbody rb in rigidBodies) {
				rb.mass *= ratio;
			}
		}
	}

	public void SetRagdollMass (float newMass) {
		totalMass = newMass;
		SetRagdollMass ();
	}

	private void SetCollisionDetectionMode () {
		if (rigidBodies == null || rigidBodies.Length == 0) {
			GetAllRigidbodies ();
		}

		if (rigidBodies != null && rigidBodies.Length != 0) {
			foreach (Rigidbody rb in rigidBodies) {
				rb.collisionDetectionMode = collisionMode;
			}
		}
	}

	private void OnValidate () {
		if (totalMass < 20f) {
			totalMass = 20f;
		}
		SetRagdollMass ();

		if (collisionMode != currentCollisionMode) {
			SetCollisionDetectionMode ();
			currentCollisionMode = collisionMode;
		}
	}
}