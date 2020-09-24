using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrounded : MonoBehaviour
{
    public PlayerBehavior myChar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D activator)
    {
        myChar.isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D activator)
    {
        myChar.isGrounded = false;
    }
}
