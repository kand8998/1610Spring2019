using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
	public UnityEvent StartEvent, EnableEvent, TriggerEnterEvent, MouseDownEvent, UpdateEvent;
	void Start () 
	{
		StartEvent.Invoke();
	}

	private void OnEnable()
	{
		EnableEvent.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{
		TriggerEnterEvent.Invoke();
	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
	}

	void Update () 
	{
		UpdateEvent.Invoke();
	}
}
