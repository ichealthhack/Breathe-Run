using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPB : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	public Transform TextLoading;
	public Transform TextStrength;
	private float minThresh = 0;
	private float maxThresh = 0;
	private double strength = -0.9;
	//[SerializeField] private float currentAmount;
	//[SerializeField] private float speed;
	float timeAmt = 0;
	float time = 0;
	int x = 0;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A)) {
			strength = strength + 0.1;
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			strength = strength - 0.1;
		}

		if (x == 0) {
			timeAmt = 2;
			minThresh = -1f;
			maxThresh = -0.4f;
		}
		if (x == 1) {
			timeAmt = 2;
			minThresh = -0.1f;
			maxThresh = 0.1f;
		}
		if (x == 2) {
			timeAmt = 3;
			minThresh = 0.6f;
			maxThresh = 1f;
		}
		TextStrength.GetComponent<Text> ().text = "strength : " + strength.ToString("F1");

		if ((strength > minThresh) && (strength < maxThresh)) {
			if (time < timeAmt) {

				time += Time.deltaTime;
				TextIndicator.GetComponent<Text> ().text = time.ToString ("F1") + " sec";
				if (x == 0) {
					TextLoading.GetComponent<Text> ().text = "Breath in";
				} else if (x == 1) {
					TextLoading.GetComponent<Text> ().text = "Hold breadth";
				} else if (x == 2) {
					TextLoading.GetComponent<Text> ().text = "Breath out";
				}
			} else {
				TextIndicator.GetComponent<Text> ().text = "DONE!";
				time = 0;
				if (x == 2) {
					x = 0;
				} else {
					x = x + 1;
				}
			}

			LoadingBar.GetComponent<Image> ().fillAmount = time / timeAmt; 
		} 
		else {
			TextIndicator.GetComponent<Text> ().text = "You can!";
		}
	}
}
