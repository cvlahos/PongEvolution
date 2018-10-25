using UnityEngine;
using System.Collections;

public class BO_Paddle : MonoBehaviour 
{
	public BO_Ball ball;
	public float paddleSpeed;
	bool isBallLaunched;

	float paddleMovingUpAndDown;
	public float rightBounds;
	public float leftBounds;



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
}
