using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerUps : MonoBehaviour 
{
	public Color TransparentColor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnMouseDown()
	{
		GetComponent<SpriteRenderer>().color = TransparentColor;
	}
}
