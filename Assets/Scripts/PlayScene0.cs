using UnityEngine;
using System.Collections;

public class PlayScene0 : MonoBehaviour
{
	void Start() 
	{
		if (Application.isEditor && (GameObject.Find("Main Scene Object") == null))
		{
			Application.LoadLevel(1);
		}
	}
}