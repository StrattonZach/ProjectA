using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour {

	//public NavMeshAgent agent;
	private Movement movement;

	// Use this for initialization
	void Start () {
		//agent = GetComponent<NavMeshAgent>();
		movement = GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) & !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
		{
			Interact();
		}
	}

	void Interact()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		//Sends the hitObject to the movement script
		if (Physics.Raycast(ray, out hit, 100))
		{
			GameObject hitObject = hit.collider.gameObject;
			
			if (hitObject.tag == "Enemy")
			{
				
				movement.MovetoAttack(hitObject);
			}
			if (hitObject.tag == "Interactable")
			{
				movement.MovetoInteract(hitObject);
			}
			if(hitObject.tag == "Enviro")
			{
				movement.MovetoDestination(hit.point);
			}
		}
			//agent.destination = hit.point;
	}
}
