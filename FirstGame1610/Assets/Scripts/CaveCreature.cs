using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveCreature : Vertebrate
{
	private void Start ()
	{
		GetComponent<SpriteRenderer>().color = SkinColor;
	} 
}
