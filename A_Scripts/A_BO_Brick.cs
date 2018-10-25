using UnityEngine;
using System.Collections;

public class A_BO_Brick : MonoBehaviour 
{
	public Ark_GameManager gameManager;
	public Ark_MusicManager musicManager;
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
		musicManager.PlayBrickHit ();
		Ark_GameManager.score++;
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
