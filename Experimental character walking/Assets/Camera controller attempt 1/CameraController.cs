using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	float speed = 10.0f;
	float turn = 100.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 rot = transform.localEulerAngles;
		rot.x += Input.GetAxis ("RightHorizontal") * turn * Time.deltaTime;
		rot.y += Input.GetAxis ("RightVertical") * turn * Time.deltaTime;
		transform.localEulerAngles = rot;
        Vector3 front = transform.forward;
        front.y = 0;
		transform.position += front * Input.GetAxis("LeftVertical") * speed * Time.deltaTime;
		transform.position += transform.right * Input.GetAxis ("LeftHorizontal") * speed * Time.deltaTime;

	}
}
