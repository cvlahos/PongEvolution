using UnityEngine;
using System.Collections;

public class Ark_Paddle : MonoBehaviour 
{
	public Ark_Ball ball;
	public float paddleSpeed;
	public bool isBallLaunched;

	float paddleMovingUpAndDown;
	public float rightBounds;
	public float leftBounds;

	public Ark_MusicManager musicManager;



	// Use this for initialization
	void Start () 
	{

		isBallLaunched = false;

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < rightBounds) 
		{
			transform.Translate(paddleSpeed * Time.deltaTime,0,0); 
		}
		
		if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > leftBounds) 
		{
			transform.Translate(-paddleSpeed * Time.deltaTime,0,0);
		}
		
		if (Input.GetKeyDown(KeyCode.Space) && isBallLaunched == false) 
			
		{
			ball.LauchBall ();
			isBallLaunched = true;
		}


	}

	void OnCollisionEnter2D()
	{
		musicManager.PlayPaddleHit ();
	}
}
