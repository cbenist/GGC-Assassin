using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour {

	GameObject[] enemy;
	GameObject zombie;
	CharacterMovement cm;
	GameObject cc;

	float distance;

	// Use this for initialization
	void Start () {
		cc = GameObject.FindGameObjectWithTag ("Player");
		cm = cc.GetComponent<CharacterMovement>();

		enemy = GameObject.FindGameObjectsWithTag ("Enemy");
		for (int i = 0; i < enemy.Length; i++) {
			zombie = enemy [i];
			distance = Vector3.Distance (transform.position, zombie.transform.position);
			if (distance < 3) {
				Destroy (zombie);
			}
		}
		distance = Vector3.Distance (transform.position, cc.transform.position);
		if (distance < 3) {
			cm.isAlive = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
