using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPB : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	public Transform TextLoading;
	//public float threshold;
	//[SerializeField] private float currentAmount;
	//[SerializeField] private float speed;
	float timeAmt = 0;
	float time = 0;
	int x = 0;
	
	// Update is called once per frame
	void Update () {

		if (x == 0) {
			timeAmt = 2;
		}
		if (x == 1) {
			timeAmt = 2;
		}
		if (x == 2) {
			timeAmt = 3;
		}

		if (time < timeAmt) {

			time += Time.deltaTime;
			TextIndicator.GetComponent<Text> ().text = time.ToString ("F1") + "sec";
			if (x == 0) {
				TextLoading.GetComponent<Text> ().text = "Breath in";
			} 
			else if (x == 1) {
				TextLoading.GetComponent<Text> ().text = "Hold breadth";
			} 
			else if (x == 2) {
				TextLoading.GetComponent<Text> ().text = "Breath out";
			}
		}
		else{
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
}
