using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
	public UnityEvent Event;
	public string Name;
	public Color SkinColor;
	public FloatData Health;
	public FloatData Speed;

	protected Color newColor;
	
	public void Move()
	{
		print("Move");
	}

	private void Start () 
	{
		Event.Invoke();
	}
	  
	private void Update ()
	{
		
	}
}
