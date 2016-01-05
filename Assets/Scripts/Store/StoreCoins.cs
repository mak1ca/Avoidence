using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StoreCoins : MonoBehaviour
{
	public Text coinsForStore;
	void Start ()
	{
		coinsForStore.text = PlayerPrefs.GetInt("Coins").ToString();
	}
	
	void Update ()
	{
		
	}
}