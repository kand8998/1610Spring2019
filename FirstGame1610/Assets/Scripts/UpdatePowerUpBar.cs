using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePowerUpBar : MonoBehaviour
{

	private Image BarImage;
	public PowerUpBase FillNumber;
	
	void Start ()
	{
		BarImage = GetComponent<Image>();
	}
	
	void Update ()
	{
		BarImage.fillAmount = FillNumber.Value;
	}
}
