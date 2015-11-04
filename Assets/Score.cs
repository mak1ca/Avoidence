using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public Text highScoreText;
	public Text scoreText;
	public 
	// Use this for initialization
	void Start () 
	{
		scoreText.text = "Final Score: " + PlayerPrefs.GetInt ("score").ToString();
		highScoreText.text = "High Score: " + PlayerPrefs.GetInt ("highscore").ToString ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
