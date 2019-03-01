using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class MushroomEvent : MonoBehaviour
{
	public UnityEvent Event, MouseDownEvent;

	private void OnCollisionEnter2D()
	{
		Event.Invoke();
	}

	private void OnMouseDown()
	{
		MouseDownEvent.Invoke();
	}
}