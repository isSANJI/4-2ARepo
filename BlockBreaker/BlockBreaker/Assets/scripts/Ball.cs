using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle myPaddle;

    float randomX, randomY;

    private Vector3 paddleToBallVector;

    bool hasStarted = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        randomX = Random.Range(0f, 0.2f);
        randomY = Random.Range(0f, 0.2f);

        //creating a Vector2 tweak with a random X and random Y
        Vector2 tweak = new Vector2(randomX, randomY);

        if (hasStarted)
        {
            this.GetComponent<AudioSource>().Play();

            //velocity = velocity + tweak
            this.GetComponent<Rigidbody2D>().velocity += tweak;

        }
    }

    // Use this for initialization
    void Start () {

        //searches for Object of Type Paddle in the scene  
        //and assigns it to myPaddle
        myPaddle = GameObject.FindObjectOfType<Paddle>();

        //saves the distance between the ball and the paddle
        paddleToBallVector = this.transform.position - myPaddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!hasStarted) //if (hasStarted == false)
        {
            //lock the ball with the paddle keeping the distance
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            //if left click is pressed
            if(Input.GetMouseButtonDown(0))
            {
                print("Left Click");
                hasStarted = true;

                //set the velocity of the ball to 2 x and 10 y
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);


            }

        }
       

        
		
	}
}
