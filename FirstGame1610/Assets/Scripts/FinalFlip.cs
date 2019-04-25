using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalFlip : MonoBehaviour 
{
	private void Update ()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(0,180,0);
		}
	}
}
