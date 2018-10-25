using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BO_GameManager : MonoBehaviour 
{
	public int score;
	public int totalBrickCount;
	static public int playerChances = 3;

	public bool detectorsEnabled;

	public Text scoreText;
	public Text playerChancesText;




	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("brick count-" + totalBrickCount);
		Debug.Log ("player chances-" + playerChances);
	


		scoreText.text = score.ToString ();
		playerChancesText.text = "Player Chances " + playerChances.ToString ();

		//playerChanceText.text = "Chances Left " + playerChances.ToString ();


		WinLevelDetector ();
		LoseGameDetector ();

	}


	public void PlayGame()
	{
		playerChances = 3;
		totalBrickCount = 0;
		score = 0;
		Application.LoadLevel("Game");
	}


	void WinLevelDetector()
	{
		if (totalBrickCount == 0) 
		{
			LoadNextLevel();
		}
	}


	void LoseGameDetector()
	{
		if (playerChances == 0) 
		{
			LoseGame();
		}
	}

	public void LoseChanceAndReset()
	{
		//totalBrickCount = 0;
		playerChances--;
		Application.LoadLevel (Application.loadedLevel);
	}
	
	public void LoadNextLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	public void LoseGame()
		
	{
		playerChances = 3;// this solves a game breaking bug of restarting the game with 0 chances...therefore intant losing 
		Application.LoadLevel("BO_Lose");
	}
}
