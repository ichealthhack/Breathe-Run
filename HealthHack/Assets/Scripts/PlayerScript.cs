using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{


  
    public Vector2 speed;//will show up in editor
    public Text dispText;
    private int inPressed; //checks if input has been pressed

    private int goRun;

    private Rigidbody2D rb;

    Animator animator;
    void Start()
    {
        goRun = 0;
        rb = GetComponent<Rigidbody2D>();
        inPressed = 0;// initialized
        //    count = 0;
        dispText.text = "Hello!, please press the button to start!";
        animator = GetComponent<Animator>();
        goRun = 0; //for the running 
    }



    void Update()
    {
        animator.SetInteger("triggerJump", 0);
        if (inPressed == 1)
        {  //if pressed start moving
            dispText.text = "You have started playing!";
            // rb.MovePosition(rb.position + speed * Time.fixedDeltaTime);
        }
        if (Input.GetKeyDown(KeyCode.A)) //jump
        {
            animator.SetInteger("triggerJump", 1);
            //Vector3 temp = new Vector3(0, 2, 0);
            //transform.position = transform.position + temp;
            //animator.ResetTrigger("triggerJump");
            // change to button later

        }
        if (Input.GetKeyDown(KeyCode.Space)) // start
        {
            inPressed = 1;
        }


        if (Input.GetKeyDown(KeyCode.L)) //run
        {
            goRun = goRun + 1;
        }

        if (inPressed == 1) // pressed to start
        {
            animator.SetInteger("triggerWalk", 1);
            animator.SetInteger("triggerIdle", 0);
            animator.SetInteger("triggerRun", 0);
        }
        if (goRun >= 3 && inPressed == 1) //run
        {
            animator.SetInteger("triggerWalk", 0);
            animator.SetInteger("triggerIdle", 0);
            animator.SetInteger("triggerRun", 1);

        }
       

    }
    void FixedUpdate()//physics
    {

        if (Input.GetKeyDown(KeyCode.A)) //jump
        {
            //Vector3 movement = new Vector3(0, 20,0);

            // rb.AddForce(movement);

            rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);

        }
        //if y pos > -2.4 set gravity to one
        // otherwise 0
        /*if ( transform.position.y > -1)
        {
            rb.gravityScale = 5;
        }
        else if (transform.position.y== -2.4)
        {
            rb.gravityScale = 0;
        }*/

    }
}
