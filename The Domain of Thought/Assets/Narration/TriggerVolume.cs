using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVolume : MonoBehaviour {

	public int index;
	public bool triggered = false;
	private Narrator narratorScript;

	void Start () {
		narratorScript = GameObject.Find("Player").GetComponent<Narrator>();
	}

	void OnTriggerEnter(Collider col) {
		if (!triggered) {
			narratorScript.resetTimes();
			narratorScript.index = index;
			triggered = true;
		}
	}
}