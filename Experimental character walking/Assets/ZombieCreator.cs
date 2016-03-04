using UnityEngine;
using System.Collections;

public class ZombieCreator : MonoBehaviour {

	public GameObject zombie;
	GameObject[] spawnPoints;

	public int wave;

	// Use this for initialization
	void Start () {
		spawnPoints = GameObject.FindGameObjectsWithTag ("Respawn");
		wave = 0;
		spawnZombies ();
	}
	
	void spawnZombies()
	{
		for (int i = 0; i < wave; i++) {
			Instantiate (zombie, spawnPoints [Random.Range (0, spawnPoints.Length)].transform.position, transform.rotation);
		}
		wave++;
		Invoke("spawnZombies", Random.Range(10, 20));
	}
}
