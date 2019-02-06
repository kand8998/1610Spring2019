using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : Animal
{

	public Color MarkingColor;
	
	// Use this for initialization
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = SkinColor;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
