using UnityEngine;
using UnityEngine.Events;

public class MushroomEvent : MonoBehaviour
{
	public UnityEvent Event;

	private void OnCollisionEnter2D()
	{
		Event.Invoke();
	}
}