using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : Round
{
	public Color BubbleColor;

	// Use this for initialization
	void Start()
	{
		GetComponent<SpriteRenderer>().color = BubbleColor;
	}

	void Update()
	{

	}
}