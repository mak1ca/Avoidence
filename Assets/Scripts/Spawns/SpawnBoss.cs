using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnBoss : MonoBehaviour
{
	public Color lightColor;
	public GameObject boss;
	public GameObject spawnedBoss = null;
	public GameObject dirLight;
	public Light dLightComp;
	private float t = 0.0f;
	public Sapwn sapwnScript;
	public IEnumerator coroute;
	private int count = 0;
	public Text scoreText;
	public AudioSource aud;
	public AudioSource startAud;
	// Use this for initialization
	void Start ()
	{
		aud.volume=PlayerPrefs.GetFloat("bgm");
		coroute = sapwnScript.SpawnEnemies();
		dirLight = GameObject.FindGameObjectWithTag("Lighting");
		dLightComp = dirLight.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Singleton.instance.score == 1 || Singleton.instance.score == 10)
		{
			//AudioSource.PlayClipAtPoint(aud.clip,this.transform.position);
			startAud.mute=true;
			aud.Play();
			if(t<=1)
			{
				dLightComp.color=Color32.Lerp(lightColor, new Color(0.0f,0.0f,255.0f),t);
				t+=Time.deltaTime/1f;
			}
			StopCoroutine(coroute);
			sapwnScript.enabled=false;
			count = count + 1;
			Debug.Log(Time.time);

			if(count==1)
			{
				StartCoroutine(SpawnTheBoss());
			}
		}
		if(spawnedBoss!=null) 
		{
			if(spawnedBoss.transform.position.z<-5.0f)
			{
				Singleton.instance.score += 10;
				scoreText.text = "Score: " + Singleton.instance.score.ToString();
				Destroy(spawnedBoss);
				this.enabled=false;
				sapwnScript.enabled=true;
				aud.Stop();
				startAud.mute = false;
			}
		}

	}
	public IEnumerator SpawnTheBoss ()
	{
		yield return new WaitForSeconds (5.5f);
		spawnedBoss = Instantiate (boss, new Vector3(0.0f,0.0f,18.0f), transform.rotation) as GameObject;

	}
}