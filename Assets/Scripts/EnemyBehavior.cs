using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{
    public float walkTimer;
    public Vector3 hor;
    public GameObject player;
    public bool moving;
    public bool stayStill;

    // Start is called before the first frame update
    void Start()
    {
        walkTimer = 0;
        moving = false;
        stayStill = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving == true)
        { 
            walkTimer += Time.deltaTime;
            if (walkTimer < 3f)
                {
                    //move left
                    hor = new Vector3(-15f, 0f, 0f);
                    GetComponent<Rigidbody2D>().AddForce(hor);
                }
            if (walkTimer > 3f)
                {
                    //move right
                    hor = new Vector3(15f, 0f, 0f);
                    GetComponent<Rigidbody2D>().AddForce(hor);

                }
            if (walkTimer > 6)
                {
                    walkTimer = 0;
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
                }
        }

    }
    void OnTriggerEnter2D(Collider2D enemy)
    {
        //enemy destoryed if hit by bullet 
        if (enemy.CompareTag("bullets"))
        {
            Debug.Log("im seeing the bullets");// not being detecte34ddddddd
            Destroy(gameObject);
        }
        // player death when enter enemy trigger
        if (enemy.CompareTag ("Player"))

        {
            Debug.Log("im seeing the player");//is being detected!!!
            Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
