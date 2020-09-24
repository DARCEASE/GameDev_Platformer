using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform cameraFocusTarget;

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D activator)
    {
        cameraFocusTarget = activator.transform;
    }
   
}
                                                                                                                