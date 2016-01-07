using UnityEngine;
using System.Collections;

public class IntroChange : MonoBehaviour 
{
	private float changeScreen = 0;

	void FixedUpdate ()
	{
		changeScreen += Time.deltaTime;
		Debug.Log(Mathf.Floor(changeScreen));
		if (changeScreen >= 3) 
		{
			Debug.Log(changeScreen);
			Application.LoadLevel("MainMenu");
		}
	}
}
