using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class StateMachine : ScriptableObject
{
	public UnityEvent StartingEvent, PlayingEvent, EndingEvent;
	public enum States
	{
		Starting,
		Playing,
		Ending
	}

	public States CurrentStates;

	public void OnSwitch() 
	{
		switch (currentStates)
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
