using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;

    private LevelManager myLevelManager;

    private int numberOfHits;

    private bool isBreakable = false;

    public static int breakableCount = 0;

    void HandleHits()
    {
        numberOfHits++;
        if (numberOfHits >= maxHits)
        {
            breakableCount--;
            Destroy(this.gameObject);
            myLevelManager.BrickDestroyed();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBreakable) //if isBreakable == true
        {
            HandleHits();
        }
        
        //SimulateWin();
    }

    void SimulateWin()
    {
        myLevelManager.LoadNextLevel();

    }


    // Use this for initialization
    void Start () {
        //depending on the tag isBreakable will be 
        //marked as True or False
        isBreakable = this.tag == ("Breakable");

        if (isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

        numberOfHits = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
