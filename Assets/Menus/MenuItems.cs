using UnityEngine;
using System.Collections;
using UnityEditor;
public class MenuItems
{
	[MenuItem("Tools/Clear PlayerPrefs")]
	private static void NewMenuOption()
	{
		PlayerPrefs.DeleteAll();
	}
	[MenuItem("Menu/Sub/Russell Is Here",false,1)]
	private static void NewMenuOption2()
	{

	}
}