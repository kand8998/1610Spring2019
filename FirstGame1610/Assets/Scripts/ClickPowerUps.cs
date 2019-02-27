using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerUps : MonoBehaviour 
{
	public Color TransparentColor;

	private void OnMouseDown()
		{
		GetComponent<SpriteRenderer>().color = TransparentColor;
		}
}
