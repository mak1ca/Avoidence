using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coin : MonoBehaviour {
	public Rigidbody rb = null;
	public Text coinText;
	private float speed = -3.0f;
	// Use this for initialization
	void Awake()
	{
		coinText = GameObject.Find("CoinText").GetComponent<Text>();
	}

	void  FixedUpdate ()
	{
		rb.velocity = new Vector3(0.0f,0.0f,1.0f) * speed;

	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag=="Player")
		{
			Singleton.instance.value++;
			PlayerPrefs.SetInt("Coins", Singleton.instance.value);
			coinText.text="Coin: " + Singleton.instance.value;
		}
		Destroy(this.gameObject);
	}
}
