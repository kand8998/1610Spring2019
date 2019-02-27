using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : Round
{
	public Color BubbleColor;
	void Start()
	{
		GetComponent<SpriteRenderer>().color = BubbleColor;
	}

}