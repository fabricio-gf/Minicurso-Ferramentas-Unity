using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh : MonoBehaviour {

    public GameObject Target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = Target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        agent.destination = Target.transform.position;
	}
}
