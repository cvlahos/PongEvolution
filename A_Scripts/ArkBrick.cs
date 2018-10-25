using UnityEngine;
using System.Collections;

public class ArkBrick : MonoBehaviour 
{
	public Ark_GameManager gameManager;
	public Ark_MusicManager musicManager;
	
	int brickDamageCount;
	
	public Sprite brokenBrickSprite;
	public SpriteRenderer brickSpriteRenderer;
	
	// Use this for initialization
	void Start () 
	{
		
		brickDamageCount = 0;
		gameManager.totalBrickCount++;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
	}
	
	void OnCollisionEnter2D()
	{
		musicManager.PlayBrickHit ();
		brickDamageCount++;
		
		if (brickDamageCount == 1) 
		{
			brickSpriteRenderer.sprite = brokenBrickSprite;
		}
		
		else if (brickDamageCount == 2) 
		{
			gameManager.totalBrickCount--;
			Destroy (gameObject);
			Ark_GameManager.score = Ark_GameManager.score + 250;
		}
		
		//Debug.Log ("collision");
		
		
		
	}
	
	void OnTriggerEnter2D()
	{
		Debug.Log ("Trigger");
		
		
	}
	
	
}
