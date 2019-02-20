using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
	public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent;
	void Start () 
	{
		StartEvent.Invoke();
		GetComponent<SpriteRenderer>();
	}

	private void OnEnable()
	{
		EnableEvent.Invoke();
		transform.Rotate(0,0,0);
	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();

	}

	void Update () 
	{
		UpdateEvent.Invoke();
		transform.Translate(0,0,0);

	}
}
