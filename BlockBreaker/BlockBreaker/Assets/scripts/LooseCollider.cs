using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

    private LevelManager myLevelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with "+ collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        myLevelManager.LoadLevel("Win");
    }

    

    // Use this for initialization
    void Start () {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
