using UnityEngine;
using System.Collections;

public class BO_Brick : MonoBehaviour 
{
	public BO_GameManager gameManager;
	// Use this for initialization
	void Start () 
	{
		gameManager.totalBrickCount++;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter2D()
	{
		//Debug.Log ("Collision Dectected");

		gameManager.score++;
		//gameManager.score = gameManager.score + 1;
		gameManager.totalBrickCount--;
		Destroy (gameObject);
		
	}
	
	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger Dectected");
		//gameManager.score = gameManager.score + 1;
		
	}


}
