using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Left : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			Vector3 movement = new Vector3 (0, transform.position.y, 0);
			rb.AddForce (movement * speed);
			print("up w key is held down");
		}
		if (Input.GetKey (KeyCode.S))
		{
			print ("down s key is held down");
			Vector3 movement = new Vector3 (0, -transform.position.y, 0);
			rb.AddForce (movement * speed);
		}
	}
}
