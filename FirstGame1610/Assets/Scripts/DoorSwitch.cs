using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorSwitch : MonoBehaviour
{
	public UnityEvent OpenEvent, CloseEvent;
	public bool OnBool;

	private void OnMouseDown()
	{
		if (OnBool)
		{
			OpenEvent.Invoke();
		}
		else
		{
			CloseEvent.Invoke();
		}
	}
}
