using UnityEngine;
using System.Collections;

public class Ark_LoseBox : MonoBehaviour 
{
	public Ark_GameManager gameManager;
	public Ark_MusicManager musicManger;
	public Transform ballTR;
	public Transform paddleTR;
	public Rigidbody2D ballRB;
	public Ark_Paddle paddle;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnCollisionEnter2D()
	{
		Debug.Log ("Collision Dectected");
	}
	
	void OnTriggerEnter2D()
	{
		musicManger.PlayLoseBox ();
		ballRB.velocity = new Vector2 (0,0);
		ballTR.parent = paddleTR;
		ballTR.position = new Vector2 (paddleTR.position.x,paddleTR.position.y + .5f);
		paddle.isBallLaunched = false;
		Ark_GameManager.playerChances--;
		//Debug.Log ("Trigger Dectected");
		
	}



}
