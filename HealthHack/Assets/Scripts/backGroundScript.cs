using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backGroundScript : MonoBehaviour {

    private int inPressed; //checks if input has been pressed
    // Use this for initialization
    public float scrollSpeed;
    private float tileSizeZ = 27;

    private Vector3 startPosition;
    void Start () {
        startPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        if (inPressed == 1)
        {  //if pressed start moving
            float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
            transform.position = startPosition + Vector3.left * newPosition;
        }

        if (Input.GetKeyDown(KeyCode.Space)) // change to button later
        {
            inPressed = 1;
           
        }
    }

}
