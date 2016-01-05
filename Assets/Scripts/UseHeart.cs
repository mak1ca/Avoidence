using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UseHeart : MonoBehaviour {
	public GameObject[] lives;
	public Text totalHearts;
	public Text totalTimer;
	public Sprite[] TimerImage;
	public Image tImage10;

	public Image iImage10;
	public Text iText;
	public Image iTimer;
	public Text iTimerText;
	public GameObject InvicShield;

	public Image dImage10;
	public Text dText;
	public Image dTimer;
	public Text dTimerText;

	private float timerHeart;
	private float timerInvinc;
	private float useTimer;
	private float destroyTimer;
	private bool canBuyHeart = true;
	private bool canUseInvinc = true;
	private bool canUseDestroy = true;
	private int powerUse;
	void Awake()
	{
		//totalTimer=GameObject.Find("Timer").GetComponent<Text>();
		totalHearts = GameObject.Find("TotalHearts").GetComponent<Text>();
		totalHearts.text = PlayerPrefs.GetInt ("Hearts").ToString();
	}
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Singleton.instance.Hearts==0)
		{
			canBuyHeart=false;
		}
		if(Singleton.instance.score >= 1)
		{
			iImage10.enabled=true;
			iText.enabled=true;
		}
		if(Singleton.instance.score >= 2)
		{
			dImage10.enabled=true;
			dText.enabled=true;
		}
		if(!canBuyHeart)
		{
			//canBuyHeart = true;
			tImage10.enabled=true;
			totalTimer.enabled=true;
			Timer ();
		}
		if(!canUseInvinc)
		{
			//canUseInvinc = true;
			iTimer.enabled=true;
			iTimerText.enabled=true;
			TimerInvinc ();
		}

		if (Singleton.instance.invinc==true)
		{
			InvincTimer();
		}
		if(!canUseDestroy)
		{
			//canUseInvinc = true;
			dTimer.enabled=true;
			dTimerText.enabled=true;
			DestroyAllEnemiesTimer ();
		}
	}
	public void MakeHeart()
	{
		if(canBuyHeart)
		{
			if(Singleton.instance.health == 2)
			{
				lives[0].GetComponent<Image>().enabled = true;
				Singleton.instance.health++;
				Singleton.instance.Hearts--;
				PlayerPrefs.SetInt ("Hearts",Singleton.instance.Hearts);
				totalHearts.text=PlayerPrefs.GetInt ("Hearts").ToString();
				canBuyHeart = false;
				powerUse=1;
				timerHeart=10.1f;
			}
			else if(Singleton.instance.health == 1)
			{
				lives[1].GetComponent<Image>().enabled = true;
				Singleton.instance.health++;
				Singleton.instance.Hearts--;
				PlayerPrefs.SetInt ("Hearts",Singleton.instance.Hearts);
				totalHearts.text=PlayerPrefs.GetInt ("Hearts").ToString();
				canBuyHeart = false;
				powerUse=1;
				timerHeart=10.1f;
			}
		}
	}
	void Timer()
	{
		timerHeart = timerHeart -Time.deltaTime;
		tImage10.sprite = TimerImage[(int)timerHeart];
		totalTimer.text = ((int)timerHeart).ToString();
		
		if((int)timerHeart == 0)
		{
			canBuyHeart = true;
			tImage10.enabled = false;
			totalTimer.enabled = false;
			iTimer.enabled = false;
			iTimerText.enabled = false;
			timerHeart = 10.1f;
		}
	}
	public void UseInvincibility()
	{
			if(canUseInvinc)
			{
				Singleton.instance.invinc=true;
				powerUse = 2;
				canUseInvinc = false;
				timerInvinc = 30.1f;
				useTimer=10.1f;
				InvicShield.SetActive(true);
			}
	}
	void TimerInvinc()
	{
		timerInvinc = timerInvinc - Time.deltaTime;
		iTimer.sprite = TimerImage[(int)timerInvinc/3];
		iTimerText.text = ((int)timerInvinc).ToString();
		
		if((int)timerInvinc == 0)
		{

			canUseInvinc = true;
			tImage10.enabled = false;
			totalTimer.enabled = false;
			iTimer.enabled = false;
			iTimerText.enabled = false;
			timerInvinc = 30.1f;
		}
	}
	void InvincTimer()
	{
		useTimer = useTimer - Time.deltaTime;
		
		if((int)useTimer == 0)
		{
			InvicShield.SetActive(false);
			Singleton.instance.invinc=false;
			useTimer=10.1f;
		}
	}
	public void DestroyAllEnemies()
	{
		if(canUseDestroy)
		{
			GameObject[] enem = GameObject.FindGameObjectsWithTag("Enemy");
			foreach(GameObject en in enem)
			{
				Destroy(en);
			}
			canUseDestroy=false;
		}
	}
	void DestroyAllEnemiesTimer()
	{
		destroyTimer =  destroyTimer - Time.deltaTime;
		dTimer.sprite = TimerImage[(int)destroyTimer/12];
		dTimerText.text = ((int)destroyTimer).ToString();
		
		if((int)destroyTimer == 0)
		{
			canUseInvinc = true;
			dImage10.enabled = false;
			dTimer.enabled = false;
			dTimerText.enabled = false;
			destroyTimer = 120.1f;
		}
	}
}