using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Destroy : MonoBehaviour
{
	public Text scoreText;
	public MainController mcont;
	void Start()
	{
		scoreText.text = "Score : 0";
	}
	// Update is called once per frame
	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.tag=="Coin")
		{
			Destroy(other.gameObject);
		}
		else
		{
			Destroy(other.gameObject);
			Singleton.instance.score += 1;
			scoreText.text = "Score : " + Singleton.instance.score.ToString();
			PlayerPrefs.SetInt ("score", Singleton.instance.score);
		}
		if (PlayerPrefs.GetInt ("highscore") < Singleton.instance.score)
		{
			PlayerPrefs.SetInt ("highscore", Singleton.instance.score);
		}
	}
}
