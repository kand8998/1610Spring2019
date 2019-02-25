using UnityEngine;
using UnityEngine.Events;

public class EggEvent : MonoBehaviour
{
	public UnityEvent Event;

	private void OnCollisionEnter2D()
	{
		Event.Invoke();
	}

}