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
	public UnityEvent UpdateEvent, MouseDownEvent, StartEvent;
	
	private void Start ()
	{
		StartEvent.Invoke();
	}
	
	private void Update ()
	{
		UpdateEvent.Invoke();
	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
		UpdateEvent.Invoke();
	}
}
