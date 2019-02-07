using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
		transform.Translate(1,0,0);
	}
}
