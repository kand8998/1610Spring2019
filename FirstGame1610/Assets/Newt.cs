using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newt : Amphibian
{

	public float EatingSpeed = 0.5f;
	public bool CanEat = true;
	
	// Use this for initialization
	void Start () 
	{
		print("Blargh!");
		GetComponent<SpriteRenderer>().color = SkinColor;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(-1,0,0);
	}
}
