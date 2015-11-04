using UnityEngine;
using System.Collections;

public class VolumeChange : MonoBehaviour {
	private AudioSource bgm;
	static bool AudioBegin = false;
	GameObject otherSound;
	void Awake()
	{
		otherSound = GameObject.FindGameObjectWithTag("Audio");
		
		if (otherSound == this.gameObject)
		{
			if (!AudioBegin)
			{
				DontDestroyOnLoad(this.gameObject);
				AudioBegin = true;
			}
		}
		else
		{
			Destroy(this.gameObject);
		}
		bgm.volume = PlayerPrefs.GetFloat ("bgm");
	}
	// Use this for initialization
	void Start ()
	{
		bgm = GameObject.FindGameObjectWithTag ("Audio").GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	public void ChangeVolume (float vol)
	{
		bgm.volume = vol;
		PlayerPrefs.SetFloat ("bgm", vol);
	}
}
