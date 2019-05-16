using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Arrows : MonoBehaviour
{
	public FloatData score;
	public UnityEvent ScoreEvent;
	private void Start () 
	{	
	}
	
	private void Update () 
	{
	}

	private void OnTriggerStay(Collider other)
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			ScoreEvent.Invoke();
		}
	}
}
