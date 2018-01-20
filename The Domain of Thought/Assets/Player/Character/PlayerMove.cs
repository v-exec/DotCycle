using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	private Transform cameraTransform;
	private Rigidbody rb;

	public float speed = 30f;

	void Start () {
		rb = GetComponent<Rigidbody>();
		cameraTransform = GameObject.Find("FilterCam").transform;
	}

	void FixedUpdate () {
		if (Input.GetKey("w")) {
			Vector3 direction = cameraTransform.forward;
			direction.y = 0;
			direction.Normalize();
			rb.AddForce(direction * speed);
		}

		if (Input.GetKey("s")) {
			Vector3 direction = -cameraTransform.forward;
			direction.y = 0;
			direction.Normalize();
			rb.AddForce(direction * speed);
		}

		if (Input.GetKey("a")) {
			Vector3 direction = Vector3.Cross(cameraTransform.forward, cameraTransform.up);
			direction.y = 0;
			direction.Normalize();
			rb.AddForce(direction * speed);
		}

		if (Input.GetKey("d")) {
			Vector3 direction = -Vector3.Cross(cameraTransform.forward, cameraTransform.up);
			direction.y = 0;
			direction.Normalize();
			rb.AddForce(direction * speed);
		}
	}
}