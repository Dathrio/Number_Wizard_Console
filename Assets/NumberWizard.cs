using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // initialize key variables
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        //welcome script for the player
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Think of a number...");
        Debug.Log("The Lowest you can pick is: " + min);
        Debug.Log("The Highest you can pick is: " + max);
        Debug.Log("Is your number higher or lower than " + guess + "?");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        //fixes bug where we can never guess 1,000
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down and update variables
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            Debug.Log("I was just warming up... My real gues is: " + guess);
        }

        //Detect when the down arrow key is pressed down and update variables
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            Debug.Log("You're a sneaky one! But your number is: " + guess);
        }

        //Computer won | restart the game
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I told you I could guess it.");
        }
    }
}
