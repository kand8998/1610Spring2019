using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButterflyEvent : MonoBehaviour
{
    public UnityEvent Event;
  private void OnCollisionEnter2D(Collision2D other)
    {
        Event.Invoke();
    }
}
