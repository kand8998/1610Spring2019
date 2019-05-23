using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Arrows : MonoBehaviour
{
	public Color CorrectColor, IncorrectColor;
	public FloatData score;
	public UnityEvent ScoreEvent;
	private void Start () 
	{	
	}

	private void OnTriggerStay(Collider other)
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			ScoreEvent.Invoke();
			GetComponent<SpriteRenderer>().color = CorrectColor;
		}
		else
		{
			GetComponent<SpriteRenderer>().color = IncorrectColor;
		}
	}
}
