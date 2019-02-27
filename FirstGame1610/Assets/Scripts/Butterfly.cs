using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class Butterfly : WingedInsect
{
	public UnityEvent MouseDownEvent;
	void Start()
	{
		print("Hello There!");
	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
		GetComponent<SpriteRenderer>().color = WingColor;
	}
}

