using UnityEngine;
using System.Collections;

public class ZombieController : MonoBehaviour {


	Animator my_anim;
	NavMeshAgent my_agent;
	GameObject target;

	// Use this for initialization
	void Start () {
		my_anim = GetComponent<Animator> ();
		my_agent = GetComponent<NavMeshAgent> ();
		target = GameObject.FindGameObjectWithTag ("Player");
	}


	
	// Update is called once per frame
	void Update () {
		my_agent.destination = target.transform.position;
		my_anim.SetBool ("isMoving", my_agent.velocity.magnitude > 0);
	
	}
}
