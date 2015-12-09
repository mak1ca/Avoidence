using UnityEngine;
using System.Collections;

public class Sapwn : MonoBehaviour 
{
	public Vector3 spawnValues;
	public GameObject[] spawn;
	public GameObject asteroid;
	public int count;
	public float spawnWait;
	int rand;
	// Use this for initialization
	void Start ()
	{
		StartCoroutine(SpawnEnemies());
	}
	
	// Update is called once per frame
	IEnumerator SpawnEnemies ()
	{
		yield return new WaitForSeconds (2.3f);
		while (true) {
			Vector3 spawnPos = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Instantiate (asteroid, spawnPos, transform.rotation);
			count++;
			Singleton.instance.count=count;
			if(Singleton.instance.count>=10)
			{
				count = 0;
				Singleton.instance.enemySpeed = Singleton.instance.enemySpeed * 1.2f;
				Singleton.instance.count = 0;
			}
			yield return new WaitForSeconds (spawnWait);
		}
	}
}
