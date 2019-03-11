using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour
{
	public int A;
	public int B;
	public int C;

	public Vector3 position;
	public CharacterController Controller;
	
	private int Add()
	{
		return A + B;

	}

	private int Subtract()
	{
		return A - B;
	}

	private int Multiply()
	{
		return C * A;
	}

	private int Math()
	{
		return A * B - 2;
	}

	public Vector3 Move()
	{
		position.y = Input.GetAxis("Horizontal");
		Controller.Move(position);
		return position;
	}

	private void Start ()
	{
		C = Add();
		C = Subtract();
		B = Multiply();
		C = Math();
	}
	

}
