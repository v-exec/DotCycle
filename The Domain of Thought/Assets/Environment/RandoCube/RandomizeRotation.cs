using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeRotation : MonoBehaviour {

	void Start () {
		float randomScale = Random.Range(0.02f, 0.1f);
		transform.localScale = new Vector3(randomScale, randomScale, randomScale);
		InvokeRepeating("fuckitup", 0.1f, 0.1f);
	}

	void fuckitup() {
		float randX = Random.Range(-180f, 180f);
		float randY = Random.Range(-180f, 180f);
		float randZ = Random.Range(-180f, 180f);

		Vector3 randomRotate = new Vector3(randX, randY, randZ);

		transform.Rotate(randomRotate, Space.Self);
	}
}