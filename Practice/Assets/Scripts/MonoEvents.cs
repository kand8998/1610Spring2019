using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents: MonoBehaviour
{

	public UnityEvent StartEvent, UpdateEvent, TriggerEnterEvent, OnTriggerExitEvent;
	private void Start ()
	{
		StartEvent.Invoke();
	}
	
	private void Update ()
	{
		UpdateEvent.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{
		TriggerEnterEvent.Invoke();
	}

	private void OnTriggerExit(Collider other)
	{
		OnTriggerExitEvent.Invoke();
	}
}
