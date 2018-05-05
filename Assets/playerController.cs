using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public Rigidbody rb;
    public float moveSpeed = 50f;
	// Use this for initialization
	void Start () {
        rb = GetComponentInParent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * moveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * moveSpeed);
        }
    }
}
