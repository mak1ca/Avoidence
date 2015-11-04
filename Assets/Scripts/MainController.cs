using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainController : MonoBehaviour
{
	public Text wave;
	// Use this for initialization
	void Awake()
	{
		wave.enabled = true;
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
