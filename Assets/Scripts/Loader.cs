using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {
	public GameObject singletonManager;
	// Use this for initialization
	void Awake () {
		if (Singleton.instance == null) 
		{
			Instantiate(singletonManager);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
