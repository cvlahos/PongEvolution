using UnityEngine;
using System.Collections;

public class BO_LevelManager : MonoBehaviour 
{
	public BO_GameManager gameManager;

	public void PlayGame()

	{

		//ameManager.playerChances = 3;
		gameManager.totalBrickCount = 0;
		gameManager.score = 0;
		Application.LoadLevel("Game");
	}

	public void LoseGame()
		
	{
		//gameManager.WinDetectorEnabled = false;
		Application.LoadLevel("Lose");
	}

	public void WinGame()
		
	{
		Application.LoadLevel("Win");
	}

	public void LoseChanceAndReset()
	{
		gameManager.detectorsEnabled = false;
		gameManager.totalBrickCount = 0;
		//gameManager.playerChances--;
		Application.LoadLevel (Application.loadedLevel);
	}

	public void LoadNextLevel()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}

}
