﻿using UnityEngine;
using System.Collections;

public class BO_Brick : MonoBehaviour 
{
	public BO_GameManager gameManager;
	// Use this for initialization
	void Start () 
	{
		gameManager.totalBrickCount = gameManager.totalBrickCount + 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter2D()
	{
		gameManager.score = gameManager.score + 1;
		gameManager.totalBrickCount = gameManager.totalBrickCount - 1;
		Destroy (gameObject);
		
		
	}
	
	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger Dectected");
		//gameManager.score = gameManager.score + 1;
		
	}


}
