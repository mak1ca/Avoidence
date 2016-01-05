using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainController : MonoBehaviour
{
	public Text wave;
	public Text coinText;
	public Text totalHearts;
	// Use this for initialization
	void Awake()
	{
		Singleton.instance.enemySpeed = -5;
		totalHearts = GameObject.Find("TotalHearts").GetComponent<Text>();
		coinText = GameObject.Find("CoinText").GetComponent<Text>();
		coinText.text = "Coin: " + PlayerPrefs.GetInt ("Coins").ToString();
		totalHearts.text = PlayerPrefs.GetInt ("Hearts").ToString();
		wave.enabled = true;
		PlayerPrefs.SetInt ("score", 0);
		Singleton.instance.health = 3;
		Singleton.instance.score = PlayerPrefs.GetInt("score");
		Singleton.instance.Hearts = PlayerPrefs.GetInt("Hearts");
		Singleton.instance.value = PlayerPrefs.GetInt("Coins");
	}
	void Start ()
	{
		StartCoroutine(WaveText ());
	}
	IEnumerator WaveText()
	{
			yield return new WaitForSeconds(2.0f);
			wave.enabled = false;
	}
	// Update is called once per frame
	void Update ()
	{
		Debug.Log (Singleton.instance.count);
		if (Singleton.instance.count > 10)
		{
			wave.enabled=true;
			StartCoroutine(WaveText ());
		}
	}
}
