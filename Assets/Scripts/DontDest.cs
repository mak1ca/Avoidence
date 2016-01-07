using UnityEngine;
using System.Collections;

public class DontDest : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}
	void Start ()
	{

	}
}
