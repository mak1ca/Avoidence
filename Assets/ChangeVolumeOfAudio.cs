using UnityEngine;
using System.Collections;

public class ChangeVolumeOfAudio : MonoBehaviour {
	public AudioSource SoundAud;
	// Use this for initialization
	void Start ()
	{
		SoundAud.volume = PlayerPrefs.GetFloat("sound");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
