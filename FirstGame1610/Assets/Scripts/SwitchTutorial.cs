using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTutorial : MonoBehaviour {

	private void Update () 
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.GetComponent<Light>().enabled = false;
		}
		else
		{
			this.GetComponent<Light>().enabled = true;
		}
	}
}
