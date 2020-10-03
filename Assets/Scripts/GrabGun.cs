using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GrabGun : MonoBehaviour
{
    public GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gun.SetActive(true);
        Destroy(gameObject);
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, .4f), transform.position.z);
    }
}
