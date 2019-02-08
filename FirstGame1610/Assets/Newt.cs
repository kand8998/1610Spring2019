using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newt : Amphibian 
{

	// Use this for initialization
	void Start () 
	{
		print("Blargh!");
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(-1,0,0);
	}
}
