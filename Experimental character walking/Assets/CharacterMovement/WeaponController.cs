using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {


	public GameObject exploPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision) {
		Instantiate (exploPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        //getGameObjectsbytag destroy if npc tag
    }
}
