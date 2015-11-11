using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyPlayer : MonoBehaviour
{
	public bool dead;
	public GameObject[] lives;
	public AudioSource aud;
	void Awake()
	{
		aud = GetComponent<AudioSource>();
		lives[0]=GameObject.Find("Live1");
		lives[1]=GameObject.Find("Live2");
		lives[2]=GameObject.Find("Live3");
		dead = Singleton.instance.dead;
	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag=="Player")
		{
			AudioSource.PlayClipAtPoint(aud.clip,this.transform.position);
			Singleton.instance.health=Singleton.instance.health-1;
			Debug.Log(Singleton.instance.health);
			if(Singleton.instance.health==2)
			{

				lives[0].GetComponent<Image>().enabled=false;
			}
			else if(Singleton.instance.health==1)
			{
				lives[0].GetComponent<Image>().enabled=false;
				lives[1].GetComponent<Image>().enabled=false;
			}
			else if(Singleton.instance.health==0)
			{
				
				lives[0].GetComponent<Image>().enabled=false;
				lives[1].GetComponent<Image>().enabled=false;
				lives[2].GetComponent<Image>().enabled=false;
				Destroy(other.gameObject);
				Application.LoadLevel(3);
			}
			//			for (int i =0;i<lives.Length;i++)
			//			{
			//				if(health == 3)
			//				{
			//
			//				}
			//			}
			Destroy(gameObject);
			//Application.LoadLevel(3);
			dead = true;
			Singleton.instance.dead=dead;
		}
	}
}