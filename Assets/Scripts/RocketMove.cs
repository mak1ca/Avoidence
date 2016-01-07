using UnityEngine;
using System.Collections;

public class RocketMove : MonoBehaviour {
	public float rockSpeed;
	public Rigidbody rb;
	// Use this for initialization
	void Start ()
	{
		rockSpeed = Singleton.instance.enemySpeed;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		rockSpeed = Singleton.instance.enemySpeed;
		rb.velocity =new Vector3(0.5f,0.0f,0.0f) * rockSpeed;
		Singleton.instance.enemySpeed = rockSpeed;
	}
	
}
