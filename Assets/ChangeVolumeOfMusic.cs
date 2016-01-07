using UnityEngine;
using System.Collections;

public class ChangeVolumeOfMusic : MonoBehaviour {
	public AudioSource MusicAud;
	// Use this for initialization
	void Start ()
	{
		MusicAud.volume = PlayerPrefs.GetFloat("bgm");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
