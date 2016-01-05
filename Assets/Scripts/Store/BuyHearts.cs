using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyHearts : MonoBehaviour
{
	public Text coinsForStore;
	public Text HeartsLeft;
	public Text messageShown;
	void Awake ()
	{
		coinsForStore.text = PlayerPrefs.GetInt("Coins").ToString();
		HeartsLeft.text = PlayerPrefs.GetInt("Hearts").ToString();
	}
	public void BuyHeart (int total)
	{
		if(Singleton.instance.value < total)
		{
			StartCoroutine(ShowMessage("Sorry, you don't have enough coins\n               to purchase that!", 2));
		}
		else 
		{
			Singleton.instance.Hearts = Singleton.instance.Hearts + total;
			PlayerPrefs.SetInt("Hearts",Singleton.instance.Hearts);
			HeartsLeft.text = PlayerPrefs.GetInt("Hearts").ToString();
			Singleton.instance.value=Singleton.instance.value-total;
			PlayerPrefs.SetInt("Coins",Singleton.instance.value);
			coinsForStore.text = PlayerPrefs.GetInt("Coins").ToString();
		}
	}
	IEnumerator ShowMessage (string message, float delay) 
	{
		messageShown.text = message;
		messageShown.enabled = true;
		yield return new WaitForSeconds(delay);
		messageShown.enabled = false;
	}
}