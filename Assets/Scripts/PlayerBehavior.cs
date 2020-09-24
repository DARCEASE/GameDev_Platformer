using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{ 
    Rigidbody2D myRB;
    float inputHor;
    bool isJumping;
    public float moveSpeed;
    public float jumpPower;
    public bool isGrounded;
     
        

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHor = Input.GetAxis("Horizontal");
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
