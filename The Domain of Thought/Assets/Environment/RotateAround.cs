using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

	public GameObject point;
	private Vector3 pivot;

	void Start () {
		pivot = point.transform.position;
	}
	
	void Update () {
		transform.RotateAround(pivot, Vector3.up, 15 * Time.deltaTime);
	}
}
