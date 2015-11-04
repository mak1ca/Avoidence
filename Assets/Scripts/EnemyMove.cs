using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	public float speed;
	public Rigidbody rb;
	// Use this for initialization
	void Start ()
	{
		speed = Singleton.instance.enemySpeed;
	}
	
	// Update is called once per frame
	void Update ()
	{
		speed = Singleton.instance.enemySpeed;
		Debug.Log (speed);
		rb.velocity =new Vector3(0.0f,0.0f,1.0f) * speed;
		Singleton.instance.enemySpeed = speed;
	}
}
