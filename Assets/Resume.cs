using UnityEngine;
using System.Collections;

public class Resume : MonoBehaviour
{
	public GameObject ResumeButton;
	public GameObject PausedBackground;
	public GameObject backObj;
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	public void ResumeGame()
	{
		Time.timeScale = 1.0f;
		//ResumeButton.SetActive(false);
		//PausedBackground.SetActive(false);
		backObj.SetActive(false);
	}
}
