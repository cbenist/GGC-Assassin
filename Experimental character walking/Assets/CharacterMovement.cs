﻿using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    CharacterController cc;
    float MoveSpeed = 5.0f;
    float RotationSpeed = 30.0f;
    float JumpHeight = 10.0f;
    bool isJumping = false;
    Vector3 upward = Vector3.zero;
    Vector3 lastForward = Vector3.zero;
	// Use this for initialization
	void Start() {
        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        

	}

    void CheckJumping() {
        if (Input.GetButtonDown("Jump") && cc.isGrounded) {
            isJumping = true;
        }
    }
    

    

    Vector3 GetUpwardVector(Vector3 forward) {
        if (!cc.isGrounded)
        {
            upward += Physics.gravity * Time.deltaTime;
        }
        /*else if (isJumping)
        {
            lastForward = forward;
            upward.y = JumpHeight;
            isJumping = false;
        }*/
       
        return upward;
    }

    void Move() {
		Vector3 for1 = transform.TransformDirection (Vector3.forward);
		for1.y = 0.0f;
        Vector3 forward = Input.GetAxis("LeftVertical") * for1 * MoveSpeed;
        Vector3 right = Input.GetAxis("LeftHorizontal") * transform.TransformDirection(Vector3.right) * MoveSpeed * 0.85f;
        transform.Rotate(new Vector3(0, Input.GetAxis("RightHorizontal"), 0) * RotationSpeed * Time.deltaTime);
		//transform.Rotate(new Vector3(Input.GetAxis("RightVertical"),0,0) * RotationSpeed * Time.deltaTime);
        /*if (cc.isGrounded)
        {
            lastForward = Vector3.zero;
        }
        else {
            forward = Vector3.zero;
        }*/

        CheckJumping();
        forward += GetUpwardVector(forward);
        //forward += lastForward;
        cc.Move(forward * Time.deltaTime);
        cc.Move(right * Time.deltaTime);
    }

    /*void Move() {
        Vector3 forward = Input.GetAxis("LeftVerticle") * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        cc.Move(forward * Time.deltaTime);
    }*/
}
