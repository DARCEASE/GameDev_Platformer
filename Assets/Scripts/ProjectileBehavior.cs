using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float shootForce = 890f;
    public Rigidbody2D Flame;
    float myRotationZ;
    float minR = -10;
    float maxR = 70;
    //left click shoot
    void Update()
    {
        // move mouse to aim
        float vertiMouseSpeed = Input.GetAxis("Mouse Y");

        // lock rotation
        myRotationZ += vertiMouseSpeed;
        myRotationZ = Mathf.Clamp(myRotationZ, minR, maxR);

        // do rotation when moved mouse
        transform.localRotation = Quaternion.Euler(0f, 0f, myRotationZ);


        // click to shoot ball
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D newClone = Instantiate(Flame, transform.position + transform.right, Quaternion.identity); //quaternion? 0, 0, 0, 0
            // adding force to "down"
            newClone.AddForce(transform.right * shootForce);
        }
    }
}
