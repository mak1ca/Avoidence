using UnityEngine;
using System.Collections;

public class Sapwn : MonoBehaviour 
{
	public Vector3 spawnValues;
	public GameObject[] spawn;
	public int count;
	public float spawnWait;
	int rand;

	void OnEnable ()
	{
		StartCoroutine(SpawnEnemies());
	}
	void OnDisable()
	{
		StopCoroutine(SpawnEnemies());
	}
	public IEnumerator SpawnEnemies ()
	{
		yield return new WaitForSeconds (2.3f);

		while (this.enabled)
		{
			Vector3 spawnPos = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Instantiate (spawn[Random.Range(0,2)], spawnPos, transform.rotation);
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
