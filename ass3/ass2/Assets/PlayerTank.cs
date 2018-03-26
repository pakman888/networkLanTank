using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : MonoBehaviour {

    public float moveSpeed = 3;
    public float rotationSpeed = 90f;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        updateMovement();	
	}

    void updateMovement()
    {
        float rotateTank = Input.GetAxis("Horizontal");
        float moveTank = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed * moveTank;

        transform.Rotate(Vector3.up * rotationSpeed * rotateTank * Time.deltaTime);
    }

}
