using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //creates 2 global integer variables
    int max = 1000;
    int min = 1;
    int guess = 500;

    void StartGame()
    {
        //Prints these once
        print("Welcome to Number Wizard");
        Debug.Log("Please think of a number from " + min + " to " + max);
        NextGuess();
    }

    void NextGuess()
    {
        print("Is number bigger or smaller than " + guess + " ?");
        print("UP: Bigger DOWN: Smaller RETURN: Equal");
    }

    // Use this for initialization
    void Start () {

        StartGame();
         
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
            
        }

        else

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        else

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("YOU WON!!! WOOHOOO");
            print("Press (P) to PLay again or (Q) to QUIT");

            if (Input.GetKeyDown(KeyCode.P))
            {
                StartGame();
            }

            else
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    UnityEditor.EditorApplication.isPlaying = false;
                }

        }
    }
}
