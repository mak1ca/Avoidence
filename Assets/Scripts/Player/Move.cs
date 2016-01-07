using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Rigidbody rb;
	public float speed, xMin, xMax, zMin, zMax;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (moveHorizontal,0.0f,0.0f);
		rb.velocity = movement * speed;
		rb.position = new Vector3
		(
			Mathf.Clamp (rb.position.x, xMin, xMax),
			0.0f,
			Mathf.Clamp (rb.position.y, zMin, zMax)
		);
	}
}
