using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public Rigidbody2D rgbd2d;
    public float flapstrength;
    public LogicScript logic;
    public bool BirdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)== true && BirdAlive== true) 
        {
            rgbd2d.velocity = Vector2.up * flapstrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        BirdAlive = false;
    }
}
