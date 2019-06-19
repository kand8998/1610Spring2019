using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents: MonoBehaviour
{

	public UnityEvent StartEvent, UpdateEvent, TriggerEnterEvent;
	private void Start ()
	{
		StartEvent.Invoke();
	}
	
	private void Update ()
	{
		UpdateEvent.Invoke();
	}

	private void OnTriggerEnter()
	{
		TriggerEnterEvent.Invoke();
	}
}
