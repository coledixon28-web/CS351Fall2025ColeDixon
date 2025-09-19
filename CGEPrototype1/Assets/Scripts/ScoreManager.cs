using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	//add this to work with textmesh pro
using TMPro;
	//add this to work with scene manager to load or reload scenes
using UnityEngine.SceneManagement;



public class ScoreManager : MonoBehaviour
{

// notice public static variables can be accessed from any script
// but cannot be seen in the inspector

	public static bool gameOver;
	public static bool won;
	public static int score;
	


	//set this in inspector
	public TMP_Text textbox;
	//set this in inspector to score needed to win
	public int scoreToWin;




	// set initial values for variables in Start()


	
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
	won = false;
	score = 0;
	

    }

    // Update is called once per frame
    void Update()
    {
	if (!gameOver)
	{
		textbox.text = "Score: " + score;
	}
        if (score >= scoreToWin)
	{
	won = true;
	gameOver = true;
	}

	if (gameOver)
	{ 
		if (won)
	{ 
		textbox.text = "You win! \nPress R to Try Again!";
	}
	else
	{
		textbox.text = "You lose! \nPress R to Try Again!";

	}
		// if they press r, reload scene
	if (Input.GetKeyDown(KeyCode.R))
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	}
    }
}
