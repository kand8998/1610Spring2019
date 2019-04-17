using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
	public UnityEvent StartEvent, TriggerEnterEvent, CollisionEnterEvent, MouseDownEvent, UpdateEvent;
	private void Start () 
	{
		StartEvent.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{
		TriggerEnterEvent.Invoke();
	}

	private void OnCollisionEnter(Collision other)
	{
		CollisionEnterEvent.Invoke();
	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
	}

	private void Update () 
	{
		UpdateEvent.Invoke();
	}
}
