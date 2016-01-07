using UnityEngine;
using UnityEditor;
using System.Collections;

class EditorScrips : EditorWindow
{
	
	[MenuItem("Play/Play Me _%h")]
	public static void RunMainScene()
	{
		EditorApplication.OpenScene("Assets/Scenes/MainMenu.unity");
		EditorApplication.isPlaying = true;
	}
}