using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreakGame : MonoBehaviour {

    public Text myText;

    private enum States
    {
        cell, sheets_0, mirror, lock_0, cell_mirror, lock_1, sheets_1, freedom
    }

    States myState;

    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to escape." +
                "There are " + "some dirty sheets on the bed, " +
                "a mirror on the wall, and the door " +
                " is locked from the outside.\n\n" +
                "Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void Sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. " +
            "Surely it's time somebody changed them." +
            " The pleasures of prison life  I guess!\n\n" +
            "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

    }

    void Mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! " +
            "There are " +  "some dirty sheets on the bed, a mirror , " +
    "and that pesky door is still there, and firmly locked!\n\n" +
    "Press R to go back Cell or T to Take the Mirror";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }

    }

    void Lock_0()
    {
        myText.text=  "This is one of those button locks. You have no idea what the " +
            "combination is. You wish you could somehow see where the dirty " +
            "fingerprints were, maybe that would help.\n\n" +
            "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

    }

    void Cell_Mirror()
    {

    }

    void Lock_1()
    {

    }

    void Sheets_1()
    {

    }

    void Freedom()
    {

    }


    // Use this for initialization
    void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {

        if (myState == States.cell)
        {
            Cell();
        }
        else if (myState == States.mirror)
        {
            Mirror();
        }
        else if(myState == States.lock_0)
        {
            Lock_0();
        }
        else if(myState == States.sheets_0)
        {
            Sheets_0();
        }
        else if (myState == States.sheets_1)
        {
            Sheets_1();
        }
        else if (myState == States.lock_1)
        {
            Lock_1();
        }
        else if (myState == States.cell_mirror)
        {
            Cell_Mirror();
        }
        else if (myState == States.freedom)
        {
            Freedom();
        }

    }
}
