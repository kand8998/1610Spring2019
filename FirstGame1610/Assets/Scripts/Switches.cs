using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour 
{
	public enum States
	{
		Starting,
		Playing,
		Ending
	}

	public States CurrentState;
	public UnityEvent StartingEvent, PlayingEvent, EndingEvent;
	
	void Update () 
	{
		switch (CurrentState)
		{
			case States.Starting:
				StartingEvent.Invoke();
				break;
			case States.Playing:
				PlayingEvent.Invoke();
				break;
			case States.Ending:
				EndingEvent.Invoke();
				break;
		}	
	}
}
