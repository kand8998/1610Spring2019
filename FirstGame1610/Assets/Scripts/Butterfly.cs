using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class Butterfly : WingedInsect
{
	private void OnMouseDown()
	{
		GetComponent<SpriteRenderer>().color = WingColor;
	}
}

