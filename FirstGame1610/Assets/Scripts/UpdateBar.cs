using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UpdateBar : MonoBehaviour
{
	public UnityEvent EndingEvent;
	public PowerUpBase Value;
	private Image BarImage;
	public FloatData FillNumber;
	
	private void Start ()
	{
		BarImage = GetComponent<Image>();
	}
	
	private void Update ()
	{
		BarImage.fillAmount = FillNumber.Value;
		
		 if (Math.Abs(FillNumber.Value) < 0.001f)
            {
             EndingEvent.Invoke();
            }
         

	}
}
