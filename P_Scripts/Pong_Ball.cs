using UnityEngine;
using System.Collections;

public class Pong_Ball : MonoBehaviour 
{

	public Rigidbody2D rb;
	public float ballSpeed;

	// Use this for initialization
	void Start () 
	{
	

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void LauchBall()
	{
		transform.parent = null;
		rb.velocity = new Vector2 (ballSpeed * Time.deltaTime, 0f);

	}

}
