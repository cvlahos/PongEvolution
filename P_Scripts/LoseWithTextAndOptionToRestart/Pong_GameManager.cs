using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pong_GameManager : MonoBehaviour 
{
	// make a reference to a text component for score
	public Text scoreText;
	// make a reference to a text component for feedback like win and lose messages 
	public Text feedbackText;

	//make a public variable to keep track the player's score use the variable type int
	public int score;

	public bool missedIt;

	// Use this for initialization
	void Start () {
		feedbackText.text = "";
		scoreText.text = "0";
		missedIt = false;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (score);
		scoreText.text = score.ToString();

		WhenYouWin ();
		WhenYouLose ();

	}

	//Make a public function to show a win message once the player scores 5 points
	public void WhenYouWin()
	{
		if (score == 5)
		{
			scoreText.text = "Great Job Champ";
		}
	}
	//Make a public function to show a lose message once the player hits the lose box
	public void WhenYouLose()
	{

		if (missedIt == true) 
		{
			feedbackText.text = "You Lose /n Hit R to restart";
			if (Input.GetKeyDown(KeyCode.R)) 
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}

		// part of the lose function should include a way for the player to restart the level and play again
		// you may want to display text saying which key to play again

	}





}
