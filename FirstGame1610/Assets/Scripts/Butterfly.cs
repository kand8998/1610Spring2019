using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class Butterfly : WingedInsect
{
	void Start()
	{
		print("Hello There!");
	}

	private void OnMouseDown()
	{
		GetComponent<SpriteRenderer>().color = WingColor;
	}
}

