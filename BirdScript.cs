using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // slot to store rigid body 2d
    public float flapStrength;
    public LogicScript logic; // reference to the logic script
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update() // this code will run multiple times
    {  
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive==true)
        {
           myRigidbody.velocity = Vector2.up * flapStrength;
        }
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive=false;  
    }

}
