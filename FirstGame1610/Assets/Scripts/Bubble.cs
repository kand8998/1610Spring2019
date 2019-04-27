using UnityEngine;

public class Bubble : Round
{
	public Color BubbleColor;
	private void Start()
	{
		GetComponent<SpriteRenderer>().color = BubbleColor;
	}

}