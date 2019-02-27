using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raccoon : Mammal
{
	public UnityEvent OnEvent;
	public FloatData Hunger;

	void Update () 
	{
		if (enabled)
		{
			OnEvent.Invoke();
		}
		transform.Translate(1,0,0);
	}
}
