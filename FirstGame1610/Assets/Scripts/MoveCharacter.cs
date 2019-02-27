using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
	public UnityEvent OnGrounded, OffGrounded;
	public float Speed = 3;
	private CharacterController controller;
	private Vector3 position;
	private void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	private void Update ()
	{
		position.y = Input.GetAxis("Vertical")* Speed* Time.deltaTime;
		position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
		controller.Move(position);
		
		if (controller.isGrounded)
		{
			OnGrounded.Invoke();
		}
		else
		{
			OffGrounded.Invoke();
		}
	}
}
