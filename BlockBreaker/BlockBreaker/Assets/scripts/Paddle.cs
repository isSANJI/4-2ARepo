using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    private Ball myBall;

	// Use this for initialization
	void Start () {

        myBall = GameObject.FindObjectOfType<Ball>();
		
	}
	
	// Update is called once per frame
	void Update () {

        float mousePosInBlocks = (Input.mousePosition.x / Screen.width * 14f) - 7f;

        //Vector3 saves any point in (x,y,z)
        //keeps the y-position fixed
        Vector3 paddlePosition = new Vector3(0.5f, this.transform.position.y, 0);

        //limit the movement of the mouse from -6.5f to 6.5f in x-axis
        paddlePosition.x = Mathf.Clamp(myBall.transform.position.x, -6.5f, 6.5f);

        //sets the position of the paddle (this) to 
        //the paddlePosition
        this.transform.position = paddlePosition;

        

        

        
		
	}
}
