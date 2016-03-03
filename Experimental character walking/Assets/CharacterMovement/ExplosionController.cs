using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour {

	GameObject[] enemy;
	GameObject zombie;

	float distance;

	// Use this for initialization
	void Start () {
		enemy = GameObject.FindGameObjectsWithTag ("Enemy");
		for (int i = 0; i < enemy.Length; i++) {
			zombie = enemy [i];
			distance = Vector3.Distance (transform.position, zombie.transform.position);
			if (distance < 3) {
				Destroy (zombie);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
