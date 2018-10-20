using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Right : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow))
		{
			print("up arrow key is held down");
			Vector3 movement = new Vector3 (0, transform.position.y, 0);
			rb.AddForce (movement * speed);
		}
		if (Input.GetKey (KeyCode.DownArrow))
		{
			print ("down arrow key is held down");
			Vector3 movement = new Vector3 (0, -transform.position.y, 0);
			rb.AddForce (movement * speed);
		}
	}
}
