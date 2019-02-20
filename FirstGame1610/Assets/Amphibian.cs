using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amphibian : Animal
{

	public Color SplotchesColor;
	
	void Start ()
	{
		GetComponent<SpriteRenderer>().color = SplotchesColor;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
