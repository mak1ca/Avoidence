using UnityEngine;
using System.Collections;

public class DestroyPlayer : MonoBehaviour
{
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag=="Player")
		{
			Destroy(other.gameObject);
			Application.LoadLevel(3);
		}
	}
}