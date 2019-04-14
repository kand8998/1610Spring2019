using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class EnemyAI : MonoBehaviour
{
	public UnityEvent TriggerEvent;
	public Transform Player;
	private NavMeshAgent agent;
	private void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		agent.destination = Player.position;
	}

	private void OnTriggerEnter(Collider other)
	{
		TriggerEvent.Invoke();
	}
}
