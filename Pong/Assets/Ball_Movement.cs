using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour {
	public float speed = 30;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = Vector3.right * speed;
	}

	void OnCollisionEnter(Collision col){
		//Note: 'col' holds the collision information. If the
		//Ball collided with a paddle, then:
		//	col.gameObject is the paddle
		//	col.transform.position is the paddle's position
		//	col.collider is the paddle's collider

		//Hit the left paddle?
		if (col.gameObject.name == "Paddle") {
			//calculate hit Factor
			float y = hitFactor (transform.position, col.transform.position, col.collider.bounds.size.y);

			//Calculate direction, make Length=1 via '.normalized'
			Vector3 dir = new Vector3 (1, y).normalized;

			//Set Velocity with dir * speed
			GetComponent<Rigidbody> ().velocity = dir * speed;
		}

		//Hit the right paddle?
		if (col.gameObject.name == "Paddle2") {
			//Calculate hit Factor
			float y = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.y);

			//Calculate direction, make length=1 via '.normalized'
			Vector3 dir = new Vector3(-1, y).normalized;

			//Set velocity with dir * speed
			GetComponent<Rigidbody>().velocity = dir * speed;
		}
	}

	float hitFactor(Vector3 SpherePos, Vector3 PaddlePos,
		float PaddleHeight) {

		return (SpherePos.y - PaddlePos.y) / PaddleHeight;
			}
	
	// Update is called once per frame
	void Update () {
		
	}
}
