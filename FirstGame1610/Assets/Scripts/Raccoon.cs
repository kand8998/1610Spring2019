using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raccoon : Mammal
{
	public FloatData Hunger;

	private void Start()
	{
		newColor = Color.magenta;
	}

	private void Update () 
	{
		if (enabled)
		{
			transform.Translate(1,0,0);
		}
	}
}
