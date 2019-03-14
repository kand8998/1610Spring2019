using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpBarEvent : MonoBehaviour
{

	public UnityEvent UpdateEvent;
	private void Start () 
	{
		
	}
	
	private void Update () 
	{
	
	}

	private void OnMouseDown()
	{
		UpdateEvent.Invoke();
	}
}
