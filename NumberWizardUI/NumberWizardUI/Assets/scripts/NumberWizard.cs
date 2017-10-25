using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    //creates 2 global integer variables
    int max = 1000;
    int min = 1;
    int guess = 500;
    int maxNumberOfGuesses = 10;

    public Text guessText;

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    
    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        //converts guess to String and updates text
        guessText.text = guess.ToString();
        maxNumberOfGuesses--;
        if(maxNumberOfGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }

    }

    void Start()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();

    }





}
