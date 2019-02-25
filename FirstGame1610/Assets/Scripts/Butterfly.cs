using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class Butterfly : WingedInsect
{
	public UnityEvent MouseDownEvent, Event;

	private void OnCollisionEnter2D(Collision2D other)
	{
		Event.Invoke();
		GetComponent<SpriteRenderer>().color = WingColor;
	}

	void Start()
	{
		print("Flutter, Flutter!");
	}

	void Update()
	{

	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
		GetComponent<SpriteRenderer>().color = WingColor;
	}
}

