using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class Butterfly : WingedInsect
{

		// Use this for initialization
		void Start()
		{
			print("Flutter, Flutter!");
			print("Flap,Flap");
		}

		// Update is called once per frame
		void Update()
		{
			GetComponent<SpriteRenderer>().color = WingColor;
		}
	}

