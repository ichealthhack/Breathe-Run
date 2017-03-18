using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreatheBar : MonoBehaviour {

    private float barDisplay = 0; //fills up bar
    private Vector2 postion; // our xy of the bar
    private Vector2 size; //size of our bar

    Texture2D progressBarEmpty;
    Texture2D progressBarFull;
    //draw our rectangle using onGui function
    void OnGui()
    {
        if (GUI.Button(new Rect(10,10,150,100),"This is Louis button"))
        {
            print("HAHA you clicked the button");
        }


    }

	/*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
}
