using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour {

    private NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Start () {
        navMeshAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {         
            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log("hit: " + hit.point);
                // check the tag of hit(object hit in raycast) and preform action based on tag
                if (hit.collider.tag == "Enemy")
                {
                    Debug.Log("Attack Enemy");
                }
                else if (hit.collider.tag == "NPC")
                {
                    Debug.Log("Interact with NPC");
                }
                else
                {
                    //Move to the area that was clicked.
                    navMeshAgent.destination = hit.point;
                }
            }
        }
	}
}
