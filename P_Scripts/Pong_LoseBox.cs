using UnityEngine;
using System.Collections;

public class Pong_LoseBox : MonoBehaviour 
{
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger Contact on lose box collider");
		Application.LoadLevel (Application.loadedLevel);
	}
	
	void OnCollisionEnter2D()
	{
		Debug.Log ("Collision Contact on lose box collider");
	}



}
