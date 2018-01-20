using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomizeCanvasElement : MonoBehaviour {

	private Image panelImage;
	public float glitchyness = 0.85f;
	public float longRectQuantity = 0.9f;
	public bool blackBars;

	void Start() {
		panelImage = GetComponent<Image>();
		InvokeRepeating("fuckitup", 0.1f, Random.Range(0.01f, 0.1f));
	}

	void fuckitup() {
		float rand = Random.Range(0f, 1f);
		if (blackBars){
			if (rand > glitchyness) panelImage.color = new Color(0f, 0f, 0f, Random.Range(0.1f, 0.8f));
			else panelImage.color = new Color(0f, 0f, 0f, 0f);
		} else {
			if (rand > glitchyness) panelImage.color = new Color(1f, 1f, 1f, Random.Range(0.1f, 0.8f));
			else panelImage.color = new Color(1f, 1f, 1f, 0f);
		}
		
		rand = Random.Range(0f, 1f);
		if (rand > longRectQuantity) panelImage.rectTransform.localScale = new Vector2(Random.Range(1f, 3f), Random.Range(0f, 0.03f));
		else panelImage.rectTransform.localScale = new Vector2(Random.Range(0.01f, 0.1f), Random.Range(0f, 0.03f));
		panelImage.rectTransform.localPosition = new Vector3(Random.Range(-120f, 120f), Random.Range(-120f, 120f), 0);
	}
}