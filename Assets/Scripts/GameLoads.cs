using UnityEngine;
using System.Collections;

public class GameLoads : MonoBehaviour
{
	public AudioSource aud;
	void OnLevelWasLoaded(int level)
	{
		aud.enabled = true;
		
	}
}

