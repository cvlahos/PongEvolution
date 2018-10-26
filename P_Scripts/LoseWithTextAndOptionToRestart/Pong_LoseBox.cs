using UnityEngine;
using System.Collections;

public class Pong_LoseBox : MonoBehaviour 
{
	//make a reference to your Pong_GameManager script and access the public lose function
	public Pong_GameManager gameManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger Contact on lose box collider");
		gameManager.missedIt = true;
	}
	
	void OnCollisionEnter2D()
	{
		Debug.Log ("Collision Contact on lose box collider");
	}



}
