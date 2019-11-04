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


	// Use this for initialization
	void Start () 
	{
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


	}

	//Make a public function to show a win message once the player scores 5 points
	public void WhenYouWin()
	{
		if (score == 5)
		{
			feedbackText.text = "Great Job Champ";
		}
	}
	//Make a public function to show a lose message once the player hits the lose box
	
}
