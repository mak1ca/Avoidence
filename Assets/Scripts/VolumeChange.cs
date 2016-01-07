using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour {
	public Slider soundVol;
	public Slider musVol;
	void Awake()
	{

	}
	// Use this for initialization
	void Start ()
	{
		soundVol.value = PlayerPrefs.GetFloat("sound");
		musVol.value=PlayerPrefs.GetFloat("bgm");
	}
	
	// Update is called once per frame
	public void ChangeSoundVolume (float vol)
	{
		PlayerPrefs.SetFloat ("sound", vol);
	}
	public void ChangeMusicVolume (float vol)
	{	
		PlayerPrefs.SetFloat ("bgm", vol);
	}
}
