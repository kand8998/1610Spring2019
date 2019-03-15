using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
	[SerializeField] private float value;
	

	public float Value
	{
		get { return value; }
		set { this.value = value; }
	}
	public void OnPowerUp(float floatInput)
	{
		Value += floatInput;
	}

}
