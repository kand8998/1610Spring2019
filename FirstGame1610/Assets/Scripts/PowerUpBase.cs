using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
	[SerializeField] private float value;
	public UnityEvent EndingEvent;
	public float Value
	{
		get { return value; }
		set { this.value = value; }
		
	}
	
	public void UpdateValue(float floatInput)
	{
		Value += floatInput;
	}

	public void Ending()
	{
		if (Value == 0)
		{
			EndingEvent.Invoke();
		}
	}

}
