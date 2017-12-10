using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour {

	//public Transform target;
	public NavMeshAgent playerAgent;

	public GameObject[] targets;

	public float playerWeaponRange = 5f;

  

	// Use this for initialization
	void Start () {
		playerAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GetTarget()
	{
		//Fancy logic to choose who to attack..
		//targets = GameObject.FindGameObjectsWithTag("Enemy");
		//target = targets[0].transform; 
	}

	public void MovetoAttack(GameObject target)
	{
		Debug.Log("Attacking: " + target);
		playerAgent.stoppingDistance = target.GetComponent<Collider>().bounds.size.x / 2 + playerWeaponRange;
		playerAgent.destination = target.transform.position;
	}

	public void MovetoInteract(GameObject target)
	{
		
		playerAgent.stoppingDistance = target.GetComponent<Collider>().bounds.size.x / 2 + 2;
		playerAgent.destination = target.transform.position;
	}

	public void MovetoDestination(Vector3 point)
	{
		playerAgent.stoppingDistance = 0;
		playerAgent.destination = point;
	}
	
}
