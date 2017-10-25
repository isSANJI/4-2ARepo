using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    //static variables are available across all instances of a class
    static MusicPlayer myMusicPlayer = null;

    //Awake() is the first method called by Unity
    //thus we are deleting the gameObject as soon as the
    //program starts
    void Awake()
    {
        //if MusicPlayer already exists
        if (myMusicPlayer != null)
        {
            Debug.Log("Destroying object " + this.gameObject.GetInstanceID().ToString());
            //destroy the new MusicPlayer
            Destroy(this.gameObject);

        }

        else //if MusicPlayer is null
        {
            //myMusicPlayer is this object
            myMusicPlayer = this;

            //this.gameObject = the gameObject attached to this script
            //DontDestroyOnLoad = dont destroy this gameObject
            //when loading a new scene
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {

        

        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
