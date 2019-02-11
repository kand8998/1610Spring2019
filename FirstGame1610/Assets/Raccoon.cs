using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raccoon : Mammal
{
	public UnityEvent Event;
	// Use this for initialization
	void Start () 
	{
		Event.Invoke();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(1,0,0);
	}
}
