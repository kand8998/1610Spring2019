using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUpEventEnable : MonoBehaviour
{

	public UnityEvent MouseDownEvent;

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
	}
	

	void Start () {
		
	}
	
	void Update()
	{
	}
}
