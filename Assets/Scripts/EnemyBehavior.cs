using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float walkTimer;
    public Vector3 hor;

    // Start is called before the first frame update
    void Start()
    {
        walkTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        walkTimer += Time.deltaTime;
        if(walkTimer < 3)
        {
            //move left
            hor = new Vector3(-3f, 0f, 0f);
            GetComponent<Rigidbody2D>().AddForce(hor);
        }
        if (walkTimer > 3)
        {
            //move right
            hor = new Vector3(3f, 0f, 0f);
            GetComponent<Rigidbody2D>().AddForce(hor);
        }
    }
}
