using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insect : Animal
{
	public Color WingColor;


// Use this for initialization
	void Start ()
	 {
		print("Hello, World!");
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(0,20,0);
	}
}
