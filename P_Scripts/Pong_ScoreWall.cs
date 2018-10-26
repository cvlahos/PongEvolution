using UnityEngine;
using System.Collections;

public class Pong_ScoreWall : MonoBehaviour 
{
	//make a reference to your Pong_GameManager script and access the score variable
	public Pong_GameManager gameManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	void OnTriggerEnter2D()
	{
		gameManager.score = gameManager.score + 1;
		Debug.Log ("Trigger Contact on score wall collider");
	}

	void OnCollisionEnter2D()
	{
		Debug.Log ("Collision Contact on score wall collider");
	}

}
