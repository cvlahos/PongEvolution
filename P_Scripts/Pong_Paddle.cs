using UnityEngine;
using System.Collections;

public class Pong_Paddle : MonoBehaviour 
{
	public Pong_Ball pongBall;
	public float paddleSpeed;
	bool isBallLaunched;

	float paddleMovingUpAndDown;
	public float topBounds;
	public float bottomBounds;



	// Use this for initialization
	void Start () 
	{

		isBallLaunched = false;

	}
	
	// Update is called once per frame
	void Update () 
	{


		if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < topBounds) 
		{
			transform.Translate(0, paddleSpeed* Time.deltaTime,0);
		}

		if (Input.GetKey(KeyCode.DownArrow)) // You need to fix this to keep the paddle in bounds look at the if statement above for a hint
		{
			transform.Translate(0, -paddleSpeed * Time.deltaTime,0);

		}
		
		if (Input.GetKey(KeyCode.Space) && isBallLaunched == false) 
		
		{
			pongBall.LauchBall ();
			isBallLaunched = true;
		}


	}
}
