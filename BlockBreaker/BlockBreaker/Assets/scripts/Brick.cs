using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;

    private int numberOfHits;

    void OnCollisionEnter2D(Collision2D collision)
    {
        numberOfHits++;
        print(numberOfHits);
    }


    // Use this for initialization
    void Start () {

        numberOfHits = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
