using UnityEngine;
using System.Collections;

public class Singleton : MonoBehaviour {
	public static Singleton instance = null;
	public int score;
	public int count;
	public float enemySpeed;

	private void Awake()
	{
		// if the singleton hasn't been initialized yet
		if (instance != null && instance != this) 
		{
			Destroy(this.gameObject);
		}
		
		instance = this;
		DontDestroyOnLoad( this.gameObject );
		score = 0;
	}
	void InitGame()
	{

	}
	private void HideWaveText()
	{
		W
	}
	public float ChangeSpeed()
	{
		enemySpeed = -5;
		return enemySpeed;
	}
}
