using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour {

	public Transform target;
	public NavMeshAgent agent;

	public GameObject[] targets;

	public float range = 3f;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        GetTarget();
        MovetoTarget();
	}

	void GetTarget()
	{
		//Fancy logic to choose who to attack..
		targets = GameObject.FindGameObjectsWithTag("Enemy");
        target = targets[0].transform; 
	}

    private void MovetoTarget()
    {
        agent.stoppingDistance = range;
        agent.destination = target.position;
    }
    
}
