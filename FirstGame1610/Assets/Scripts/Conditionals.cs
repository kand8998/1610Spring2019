using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
	public bool CanWalk;
	public int Number;
	public string Password;

	private void OnMouseDown()
	{
		if (!CanWalk)
		{
			print("True");
		}
		else
		{
			print(false);
		}
		if (Number >= 10)
		{
			print("Greater");
		}
		else
		{
			print("Lesser");
		}

		if (Password == "Tomorrow")
		{
			print("...a place where things are better");
		}
	}
}
