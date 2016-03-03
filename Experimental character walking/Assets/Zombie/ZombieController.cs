using UnityEngine;
using System.Collections;

public class ZombieController : MonoBehaviour {

	public GameObject zombie;

	Animator my_anim;
	NavMeshAgent my_agent;
	GameObject[] spawnPoints;
	GameObject target;

	// Use this for initialization
	void Start () {
		my_anim = GetComponent<Animator> ();
		my_agent = GetComponent<NavMeshAgent> ();
		spawnPoints = GameObject.FindGameObjectsWithTag ("Respawn");
		target = GameObject.FindGameObjectWithTag ("Player");
		Invoke ("spawnZombies", Random.Range(3,10));
	}

	void spawnZombies()
	{
		Instantiate (zombie, spawnPoints [Random.Range (0, spawnPoints.Length)].transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		my_agent.destination = target.transform.position;
		my_anim.SetBool ("isMoving", my_agent.velocity.magnitude > 0);
	
	}
}
