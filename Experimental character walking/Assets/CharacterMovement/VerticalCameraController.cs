using UnityEngine;
using System.Collections;

public class VerticalCameraController : MonoBehaviour {
    float cameraVertRotationSpeed = 5.0f;
    GameObject GOPlayer;
    

	// Use this for initialization
	void Start () {
        GOPlayer = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 vLook;
        vLook = new Vector3(Input.GetAxis("RightVertical"), 0, 0);
        transform.Rotate(vLook);
        

	}

    
}
