using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	public void ChangeToScene (int sceneToChangeTo)
	{
		Application.LoadLevel (sceneToChangeTo);
		//DontDestroyOnLoad (this.gameObject);
	}
}
