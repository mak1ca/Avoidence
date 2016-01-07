using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	private bool paused;
	public GameObject backObj;
	public GameObject ResumeButton;
	public GameObject PausedBackground;
	void Awake()
	{
		
	}

	void Start ()
	{
	
	}
	void FixedUpdate()
	{
		if(paused)
		{
			ResumeButton.SetActive(true);
		}
	}
	public void Paused()
	{
		Time.timeScale = 0;
//		ResumeButton.SetActive(true);
//		PausedBackground.SetActive(true);
		backObj.SetActive(true);
	}

	void OnApplicationPause(bool pauseStatus)
	{
		paused = pauseStatus;
	}
}
