using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TankMovement : MonoBehaviour {

    public float moveSpeed;
    public float turnSpeed;
    private Rigidbody rb;
    private float movementInputValue;
    private float turnInputValue;

    //Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        Turn();
	}

    void Move()
    {
        movementInputValue = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * movementInputValue * moveSpeed * Time.deltaTime;

        rb.MovePosition(rb.position + movement);
    }

    void Turn()
    {
        turnInputValue = Input.GetAxis("Horizontal");

        float turn = turnInputValue * turnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);

        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
