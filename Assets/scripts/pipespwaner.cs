using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespwaner : MonoBehaviour
{
    public float movespeed = 5;
    public float deathtimer = -30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<deathtimer)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left* movespeed)* Time.deltaTime;
    }
}
