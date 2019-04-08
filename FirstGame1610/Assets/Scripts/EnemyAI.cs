using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
	public Transform Player;
	private NavMeshAgent agent;
	
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		agent.destination = Player.position;
	}
}
