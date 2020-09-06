using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour {

	public bool ragdollEnabled;
	public PhysicMaterial physicsMaterial;
	public float totalMass;
	public CollisionDetectionMode collisionMode;

	private Rigidbody[] rigidBodies;
	private CharacterJoint[] joints;

	private PhysicMaterial currentMaterial;
	private bool ragdollCurrentlyEnabled;
	private CollisionDetectionMode currentCollisionMode;

	private void Awake () {
		if (joints == null)
			GetAllRagdollComponents ();
		foreach (CharacterJoint joint in joints) {
			joint.enableProjection = true;
		}
		SetRagdollActive (ragdollEnabled);
	}

	public void SetRagdollActive (bool active) {
		if (rigidBodies == null) {
			GetAllRagdollComponents ();
		}

		foreach (Rigidbody rb in rigidBodies) {
			if (!active)
				rb.collisionDetectionMode = CollisionDetectionMode.Discrete;
			if (!active)
				rb.velocity = Vector3.zero;
			rb.isKinematic = !active;
			rb.GetComponent<Collider> ().isTrigger = !active;
			if (active)
				rb.collisionDetectionMode = currentCollisionMode;
		}

		ragdollCurrentlyEnabled = active;
	}

	public void SetRagdollActive (bool active, Vector3 velocity) {
		SetRagdollActive (active);
		foreach (Rigidbody rb in rigidBodies) {
			rb.AddForce (velocity * 50f);
		}
	}

	public void GetAllRagdollComponents () {
		rigidBodies = GetComponentsInChildren<Rigidbody> ();
		joints = GetComponentsInChildren<CharacterJoint> ();
	}

	private void SetRagdollMass () {
		if (rigidBodies == null || rigidBodies.Length == 0) {
			GetAllRagdollComponents ();
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
			GetAllRagdollComponents ();
		}

		if (rigidBodies != null && rigidBodies.Length != 0 && ragdollCurrentlyEnabled) {
			foreach (Rigidbody rb in rigidBodies) {
				rb.collisionDetectionMode = collisionMode;
			}
		}
	}

	private void SetPhysicsMaterial (PhysicMaterial mat) {
		if (rigidBodies == null)
			GetAllRagdollComponents ();
		foreach (Rigidbody rb in rigidBodies) {
			rb.GetComponent<Collider> ().material = mat;
		}
		currentMaterial = mat;
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

		if (ragdollEnabled != ragdollCurrentlyEnabled) {
			SetRagdollActive (ragdollEnabled);
		}

		if (physicsMaterial != currentMaterial) {
			SetPhysicsMaterial (physicsMaterial);
		}
	}
}