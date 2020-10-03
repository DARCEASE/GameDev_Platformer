using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform cameraFocusTarget;

    void OnTriggerEnter2D(Collider2D activator)
    {
        cameraFocusTarget = activator.transform;
    }// Update is called once per frame
    void Update()
    {
        if (cameraFocusTarget != null)
        {
            Vector3 moveVector = cameraFocusTarget.position - Camera.main.transform.position;
            if (moveVector.magnitude > 1f)
            {
                moveVector = moveVector.normalized;
            }
            moveVector.z = 0f; 
            Camera.main.transform.position += moveVector * Time.deltaTime * 20f;
        }

    }
}
                                                                                                                