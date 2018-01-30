﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization

	int max = 1000;
	int min = 1;
	int guess = 500;

	void Start () 
	{
		StartGame();
	}

	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;

		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess + "?");
		print ("Up key for higher, down for lower, return for equal");

		max += 1;
	}

	void NextGuess()
	{
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("up"))
		{
			// print ("Up arrow pressed");
			min = guess;
			NextGuess();
		}

		else if (Input.GetKeyDown("down"))
		{
			//print ("Down arrow was pressed");
			max = guess;
			NextGuess();
		}

		else if(Input.GetKeyDown("return"))
		{
			print ("I won!");
			StartGame();
		}
		
	}
}
