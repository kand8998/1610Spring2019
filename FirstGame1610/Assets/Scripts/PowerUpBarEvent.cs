using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class PowerUpBarEvent : MonoBehaviour
{

	public UnityEvent UpdateEvent, MouseDownEvent;
	private void Start () 
	{
		
	}
	
	private void Update () 
	{
		UpdateEvent.Invoke();
	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
	}
}
