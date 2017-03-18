using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{


    private Rigidbody2D rb; //variable to hold reference to object ( Rgigitbody)
    public Vector2 speed;//will show up in editor
    public Text dispText;
    private int inPressed; //checks if input has been pressed
   


    Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inPressed = 0;// initialized
        //    count = 0;
        dispText.text = "Hello!, please press the button to start!";
        animator = GetComponent<Animator>();
    }



    void FixedUpdate()//physics
    {

        if (inPressed == 1)
        {  //if pressed start moving
            dispText.text = "You have started playing!";
           // rb.MovePosition(rb.position + speed * Time.fixedDeltaTime);
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // change to button later
        {
            inPressed = 1;
            animator.SetInteger("triggerWalk", 1);
          animator.SetInteger("triggerIdle", 0);
        }

    }
}
