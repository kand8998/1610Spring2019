﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Butterfly : Insect
{
	public UnityEvent Event;

	private void OnCollisionEnter2D(Collision2D other)
	{
		Event.Invoke();

	}

	// Use this for initialization
	void Start () 
	{
		print("Flutter, Flutter!");
		print("Flap,Flap");
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<SpriteRenderer>().color = WingColor;
	}
}
