using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insect : Animal
{
	public Color WingColor;


// Use this for initialization
	void Start ()
	 {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(0,1,0);
	}
}
