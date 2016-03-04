using UnityEngine;
using System.Collections;

public class ZombieController : MonoBehaviour {


	Animator my_anim;
	NavMeshAgent my_agent;
	GameObject target;
	CharacterMovement m;
	float distance;

	// Use this for initialization
	void Start () {
		my_anim = GetComponent<Animator> ();
		my_agent = GetComponent<NavMeshAgent> ();
		target = GameObject.FindGameObjectWithTag ("Player");
		m = target.GetComponent<CharacterMovement> ();
	}


	
	// Update is called once per frame
	void Update () {
		my_agent.destination = target.transform.position;
		my_anim.SetBool ("isMoving", my_agent.velocity.magnitude > 0);

		distance = Vector3.Distance (transform.position, target.transform.position);

		if (distance < 3) {
			m.isAlive = false;
		}
	
	}
}
