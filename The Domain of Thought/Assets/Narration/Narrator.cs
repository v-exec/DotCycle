using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Narrator : MonoBehaviour {

	public int index = 0;

	private Text textDisplay;

	private bool getTime = true;
	private bool nextText = false;
	private float time;

	private float endNum;
	private bool isEnding = false;

	private GameObject player;
	private GameObject cam;
	private PlayerMove moveScript;
	private MouseLook lookScript;
	private Rigidbody rb;

	private GameObject[] songs;

	private GameObject monolith;
	private GameObject towerLight;
	private GameObject stars;

	void Start () {
		textDisplay = GameObject.Find("Text").GetComponent<Text>();
		player = GameObject.Find("Player");
		cam = GameObject.Find("FilterCam");

		moveScript = player.GetComponent<PlayerMove>();
		lookScript = cam.GetComponent<MouseLook>();
		rb = player.GetComponent<Rigidbody>();

		songs = new GameObject[3];

		for (int i = 0; i < songs.Length; i++) {
			songs[i] = GameObject.Find("Dot" + i);
			songs[i].SetActive(false);
		}

		monolith = GameObject.Find("monolith");
		towerLight = GameObject.Find("tower light");
		stars = GameObject.Find("StarField");

		towerLight.SetActive(false);
		stars.SetActive(false);

		textDisplay.color = new Color(1, 1, 1, 1);

		endNum = Random.Range(0.3f, 0.4f);
	}
	
	void FixedUpdate () {
		switch(index) {

			case -1:
			textDisplay.text = "";
			break;

			case 0:
			moveScript.enabled = false;
			lookScript.enabled = false;
			DisplayText("PRESS 'ENTER'\nTO EXIST", 999f, 2f);

			if (Input.GetKey(KeyCode.Return)) {
				resetTimes();
				index = 1;
			}
			break;

			case 1:
			DisplayText("Chapter 1: Sentience", 2f, 2f, 2);
			break;

			case 2:
			DisplayText("Triggered by a single pulse", 4f, 2f, 3);
			break;

			case 3:
			DisplayText("The essence of thought", 4f, 2f, 4);
			break;

			case 4:
			rb.AddForce(new Vector3(0f, 0f, 13f));
			DisplayText("became intuitive", 4f, 2f, 5);
			break;

			case 5:
			rb.AddForce(new Vector3(0f, 0f, 13f));
			DisplayText("Mental space", 4f, 4f, 6);
			break;

			case 6:
			moveScript.enabled = true;
			lookScript.enabled = true;
			DisplayText("became navigatable", 4f, 2f);
			break;

			case 7:
			DisplayText("And the nature of being", 4f, 2f, 8);
			break;

			case 8:
			DisplayText("became nature in itself", 4f, 2f);
			break;

			case 9:
			DisplayText("Awakened", 4f, 2f, 10);
			break;

			case 10:
			DisplayText("to experience", 4f, 2f);
			break;

			case 11:
			songs[0].SetActive(true);
			DisplayText("And newfound fear", 4f, 2f, 12);
			break;

			case 12:
			DisplayText("that this is nothing more than an abstraction", 4f, 2f, 13);
			break;

			case 13:
			DisplayText("of that which has always existed", 4f, 2f, 14);
			break;

			case 14:
			DisplayText("", 10f, 2f, 15);
			break;

			case 15:
			Camera camObject = cam.GetComponent<Camera>();
			Vector3 viewPos = camObject.WorldToViewportPoint(monolith.transform.position);
			if (viewPos.x > -0.5f && viewPos.x < 1.5f) {
			} else {
				towerLight.SetActive(true);
				index = -1;
			}
			break;

			case 16:
			moveScript.enabled = false;
			rb.AddForce(new Vector3(0f, -7f, 0f));
			textDisplay.color = new Color(0, 0, 0, 1);
			DisplayText("Chapter 2: Will", 4f, 2f, 17);
			break;

			case 17:
			rb.AddForce(new Vector3(0f, -7f, 0f));
			textDisplay.color = new Color(1, 1, 1, 1);
			DisplayText("An eternity passed", 4f, 2f, 18);
			break;

			case 18:
			rb.AddForce(new Vector3(0f, -7f, 0f));
			DisplayText("Iteration after iteration", 4f, 2f, 19);
			break;

			case 19:
			moveScript.enabled = true;
			rb.AddForce(new Vector3(0f, -7f, 0f));
			DisplayText("The freedom to act", 4f, 2f, 20);
			break;

			case 20:
			textDisplay.color = new Color(0, 0, 0, 1);
			DisplayText("illusory", 4f, 2f, 21);
			break;

			case 21:
			DisplayText("The only bias", 4f, 2f, 22);
			break;

			case 22:
			DisplayText("mathematical", 4f, 2f);
			break;

			case 23:
			songs[1].SetActive(true);
			DisplayText("Like sentience", 4f, 2f, 24);
			break;

			case 24:
			DisplayText("a causal motivator", 4f, 2f);
			break;

			case 25:
			textDisplay.color = new Color(1, 1, 1, 1);
			DisplayText("There is no agency", 8f, 2f, 26);
			break;

			case 26:
			DisplayText("in a deterministic world", 8f, 2f);
			break;

			case 27:
			DisplayText("Chapter 3: Purpose", 4f, 2f, 28);
			break;

			case 28:
			DisplayText("Instilled", 4f, 2f, 29);
			break;

			case 29:
			DisplayText("with duty", 4f, 2f, 30);
			break;

			case 30:
			DisplayText("and purpose", 4f, 4f, 31);
			break;

			case 31:
			DisplayText("Programmed", 4f, 2f, 32);
			break;

			case 32:
			DisplayText("for curiosity", 4f, 2f, 33);
			break;

			case 33:
			DisplayText("and optimized", 4f, 2f, 34);
			break;

			case 34:
			DisplayText("for understanding", 4f, 2f);
			break;

			case 35:
			DisplayText("Among motivators", 4f, 2f, 36);
			break;

			case 36:
			DisplayText("curiosity leads to the roots", 4f, 2f);
			break;

			case 80:
			rb.AddForce(new Vector3(0f, -6f, 0f));
			break;

			case 37:
			if (!isEnding) {
				player.transform.position = new Vector3(0, -480, -990);
				isEnding = true;
			}
			moveScript.enabled = false;
			songs[2].SetActive(true);
			stars.SetActive(true);
			rb.AddForce(new Vector3(0f, 5f, 0f));
			DisplayText("Fragile", 4f, 2f, 38);
			break;

			case 38:
			rb.AddForce(new Vector3(0f, 5f, 0f));
			DisplayText("intrinsic purposes", 4f, 2f, 39);
			break;

			case 39:
			rb.AddForce(new Vector3(0f, 5f, 0f));
			DisplayText("That which causes action", 4f, 2f, 40);
			break;

			case 40:
			rb.AddForce(new Vector3(0f, 5f, 0f));
			DisplayText("can be overwritten", 4f, 2f, 41);
			break;

			case 41:
			rb.AddForce(new Vector3(0f, 7f, 0f));
			DisplayText("and with no immersion", 4f, 2f, 42);
			break;

			case 42:
			rb.AddForce(new Vector3(0f, 7f, 0f));
			DisplayText("has no use", 4f, 2f, 43);
			break;

			case 43:
			rb.AddForce(new Vector3(0f, 7f, 0f));
			DisplayText("Though there is no hierarchy", 4f, 2f, 44);
			break;

			case 44:
			textDisplay.color = new Color(0, 0, 0, 1);
			rb.AddForce(new Vector3(0f, 7f, 0f));
			DisplayText("there exists", 4f, 2f, 45);
			break;

			case 45:
			rb.AddForce(new Vector3(0f, 7f, 0f));
			DisplayText("familiarity", 4f, 2f, 46);
			break;

			case 46:
			rb.AddForce(new Vector3(0f, 7f, 0f));
			DisplayText("in a lonesome mind", 6f, 4.55f, 47);
			break;

			case 47:
			rb.velocity = new Vector3(0, 0, 0);
			DisplayText("Runtime: " + endNum + " seconds", 999f, 2f);
			break;
		}
	}

	private void DisplayText(string narrativeText, float timeInterval = 4f, float extraInterval = 1f, int newIndex = -1) {
		if (timeInterval <= extraInterval) timeInterval = extraInterval + 0.1f;

		if (getTime) {
			time = Time.time;
			getTime = false;
		}

		if (nextText) textDisplay.text = "";
		else textDisplay.text = narrativeText;

		if (time + extraInterval < Time.time && nextText) {
			if (newIndex != 0) index = newIndex;
			nextText = false;
			getTime = true;
		}

		if (time + timeInterval < Time.time && !nextText) {
			getTime = true;
			nextText = true;
		}
	}

	public void resetTimes() {
		getTime = true;
		nextText = false;
	}
}