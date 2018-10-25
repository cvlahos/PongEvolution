using UnityEngine;
using System.Collections;

public class BO_Menu : MonoBehaviour 
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
			Ark_GameManager.playerChances = 3; //this will fix a player chances game bug
			Application.LoadLevel("BO_Game_01");
	
		}


	}
}
