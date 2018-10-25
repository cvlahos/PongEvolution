using UnityEngine;
using System.Collections;

public class Ark_Menu : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetKeyDown(KeyCode.P)) 
		{
			Ark_GameManager.score = 0;
			Application.LoadLevel("Ark_Game_01");
	
		}


	}
}
