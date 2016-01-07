using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {
	public float distance = 3.0f;
	private float speed = 10.0f;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float speedTemp = Singleton.instance.enemySpeed;
		if(speed<speedTemp)
		{
			speed = speedTemp;
		}
		var ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
		var plane = new Plane(Vector3.up, transform.position);
		float dist = 3.0f;
		if (plane.Raycast(ray, out dist))
		{
			transform.position = Vector3.MoveTowards(transform.position, ray.GetPoint(dist), speed * Time.deltaTime);
		}


//		Vector3 mousePoisition = Input.mousePosition;
//		mousePoisition.z=distance;
//		transform.position=Camera.main.ScreenToWorldPoint(mousePoisition);
//	
	}
}
