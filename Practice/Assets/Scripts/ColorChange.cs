using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour 
{

	// Unity Color Change Tutorial
	private void Start () 
	{
		
	}
	
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.C))
		{
			GetComponent<Renderer>().material.color = Color.cyan;
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			GetComponent<Renderer>().material.color = Color.clear;
		}
		
	}
}
