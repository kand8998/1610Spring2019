using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.PlayerLoop;

public class LightSwitch : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;
    public bool OnBool;

    private void Update()
    {
        if (OnBool)
        {
            OnEvent.Invoke();
        }
        else
        {
            OffEvent.Invoke();
        }
    }
}
 
