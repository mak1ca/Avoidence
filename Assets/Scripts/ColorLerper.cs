using UnityEngine;
using System.Collections;

public class ColorLerper : MonoBehaviour {
	public Color lightColor;
	public GameObject dirLight;
	public Light dLightComp;
	private float t = 0.0f;

	void Start ()
	{
		dirLight = GameObject.FindGameObjectWithTag("Lighting");
		dLightComp = dirLight.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if(Singleton.instance.score>10)
		{
		//	t = 0;
			if(t <= 1)
			{
				dLightComp.color=Color32.Lerp(lightColor,new Color(255.0f,244.0f,214.0f,255.0f),t);
				t += Time.deltaTime/1.1f;
			}
		}
	}
}
