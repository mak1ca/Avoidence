using UnityEngine;
using System.Collections;

public class Singleton : MonoBehaviour {
	public static Singleton instance = null;
	public int score;
	public int count;
	public int health;
	public float enemySpeed;
	public bool dead;

	private void Awake()
	{
		// if the singleton hasn't been initialized yet
		if (instance != null && instance != this) 
		{
			Destroy(this.gameObject);
		}
		dead=false;
		instance = this;
		DontDestroyOnLoad( this.gameObject );
		PlayerPrefs.SetInt ("score", 0);
		health = 3;
		score = 0;
	}
	void InitGame()
	{

	}
	private void HideWaveText()
	{

	}
	public float ChangeSpeed()
	{
		enemySpeed = -5;
		return enemySpeed;
	}
}
