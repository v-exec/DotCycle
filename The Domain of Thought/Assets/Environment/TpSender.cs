using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpSender : MonoBehaviour {

	private int tpTimes = 0;
	public int recieverIndex = 0;
	public int tpThreshold = 0;
	public bool acceptFirstPass;
	public string tpAxis = "x";
	GameObject reciever;
	GameObject player;

	void Start () {
		reciever = GameObject.Find("Tp Recieve " + recieverIndex);
		player = GameObject.Find("Player");
	}
	
	void OnTriggerEnter(Collider col) {
		if (acceptFirstPass) {
			if (tpTimes == 0) {
				tpTimes++;
				return;
			}
		}
		if (tpTimes < tpThreshold) {
			switch(tpAxis) {
				case "x":
				player.transform.position = new Vector3(reciever.transform.position.x, player.transform.position.y, player.transform.position.z);
				break;

				case "z":
				player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, reciever.transform.position.z);
				break;

				case "x+z":
				player.transform.position = new Vector3(reciever.transform.position.x, player.transform.position.y, reciever.transform.position.z);
				break;
			}
			tpTimes++;
		}
	}
}
