﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodyScript : MonoBehaviour {

    // Use this for initialization
    private Rigidbody2D rb;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void FixedUpdate()//physics
    {
            Vector3 movement = new Vector3(10, 10, 10);

            rb.AddForce(movement);
    }
   
}
