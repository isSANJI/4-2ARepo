using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;

    public AudioClip myClip;

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
            AudioSource.PlayClipAtPoint(myClip, this.transform.position);

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

    void Awake()
    {
        
        
        
    }

    void GenerateRandomBricks()
    {
        print("Level " + myLevelManager.GetCurrentLevel());
        print("Screen: "+ Screen.width);
    }


    // Use this for initialization
    void Start () {
        myLevelManager = GameObject.FindObjectOfType<LevelManager>();
        if (myLevelManager.GetCurrentLevel() == "Level03")
        {
            GenerateRandomBricks();
        }

        numberOfHits = 0;
        
        //depending on the tag isBreakable will be 
        //marked as True or False
        isBreakable = this.tag == ("Breakable");

        if (isBreakable)
        {
            breakableCount++;
            
        }

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
