using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.PlayerLoop;

public class LightSwitch : MonoBehaviour
{

    public bool Light;
    public UnityEvent Event;

    private void Update()
    {
        if (Light)
            {
                Event.Invoke();
            }
        else
            {
                print("try again");
            } 
        }
    
    }
 
