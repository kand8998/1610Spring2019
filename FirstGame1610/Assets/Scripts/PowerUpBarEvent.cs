using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.Experimental.UIElements;
using UnityEngine.XR.WSA.Input;

public class PowerUpBarEvent : MonoBehaviour
{
	public PowerUpBase Value;
	public UnityEvent StartEvent, UpdateEvent, TriggerEnterEvent;
	
	private void Start ()
	{
		StartEvent.Invoke();
	}
	
	private void Update ()
	{
	
	}

	private void OnTriggerEnter(Collider other)
	{
		UpdateEvent.Invoke();
		TriggerEnterEvent.Invoke();
	}
}
