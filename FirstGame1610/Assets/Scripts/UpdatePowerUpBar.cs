using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePowerUpBar : MonoBehaviour
{

	private Image BarImage;
	public PowerUpBase FillNumber;
	
	private void Start ()
	{
		BarImage = GetComponent<Image>();
	}


	private void Update ()
	{
		BarImage.fillAmount = FillNumber.Value;
	}
}
