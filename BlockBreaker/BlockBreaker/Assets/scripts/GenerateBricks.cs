using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBricks : MonoBehaviour {

    public List<GameObject> listOfBricks = new List<GameObject>();

	// Use this for initialization
	void Start () {

        //gets all GameObjects from Resources folder
        //and adds them to listOfBricks
        listOfBricks.AddRange(Resources.LoadAll<GameObject>(""));

        /* foreach(GameObject go in listOfBricks)
         {
             print("Brick: " + go.name);
         }*/

        //creates the first row
        Vector3 position = new Vector3(-5f, 3f, 0);

        for (int row = 1; row <= 6; row++)
        {
            //creates bricks
            for (int i = 1; i <= 11; i++)
            {
                int rand = (int)Random.Range(0f, listOfBricks.Count);
                GameObject myGameObject = listOfBricks[rand];

                //creates myGameObject brick in the Scene at runtime
                //at the position 
                Instantiate(myGameObject, position, Quaternion.identity);

                position.x += 1f;
            }
            //reset x position
            position.x = -5f;
            //move y position downwards
            position.y -= 0.3f;
        }
        /*
        position = new Vector3(-5f, 2.6f, 0);

        for (int i = 1; i <= 11; i++)
        {
            int rand = (int)Random.Range(0f, listOfBricks.Count);
            GameObject myGameObject = listOfBricks[rand];

            //creates myGameObject brick in the Scene at runtime
            //at the position 
            Instantiate(myGameObject, position, Quaternion.identity);

            position.x += 1f;
        }*/


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
