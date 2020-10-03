using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class PlayerBehavior : MonoBehaviour
{ 
    Rigidbody2D myRB;
    float inputHor;
    bool isJumping;
    public float moveSpeed;
    public float jumpPower;
    public bool isGrounded;
    public bool lookLeft;
    public bool lookRight;
    public Animator playerAnim;// calls for animator 
     

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>(); // similar to RB just to do a thing i guess 
        myRB = GetComponent<Rigidbody2D>();
        lookLeft = false;
        lookRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        //this will activfate the animator when idle 
        //thing 
        inputHor = Input.GetAxis("Horizontal");
        if (inputHor < 0 && !lookLeft)
        {
            lookLeft = true;
            lookRight = false;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (inputHor > 0 && !lookRight)
        {
            lookRight = true;
            lookLeft = false;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetButtonDown("Jump") && isGrounded == true) 
        {
            isJumping = true;
        }

    }
    void FixedUpdate()
    {
        myRB.velocity = new Vector2(inputHor * moveSpeed, myRB.velocity.y);
        if (isJumping == true)
        {
            myRB.velocity = new Vector2(myRB.velocity.x, jumpPower);
            isJumping = false;

        }
    }
}
