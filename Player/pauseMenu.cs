using UnityEngine;
using System.Collections;

public class pauseMenu : MonoBehaviour {
	
	public GUISkin myskin;
	public GUIStyle customButton;
	public GUIStyle customButton1;
	private Rect windowRect;
	private bool paused = false , waited = true, option = false;
	//public FirstPersonController control;
	
	
	
	
	
	private void Start()
	{
		windowRect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 300);
		AudioListener.pause = false;
		
	}
	
	private void waiting()
	{
		waited = true;
	}
	
	private void Update()
	{
		if (waited)
			if (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.P))
		{
			GameObject.Find("FPSController").GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled=false;
			GameObject.Find("Samurai").GetComponent<EnemyModelMovement>().enabled=false;
			
			if (paused)
				
				paused = false;
			else
				paused = true;
			
			waited = false;
			Invoke("waiting",0.3f);
		}
		if (paused)
		{
			Time.timeScale = 0;	
			
		} 
		else 
		{
			Time.timeScale = 1;	
		}
	}
	
	private void OnGUI()
	{
		if (paused) 
		{	
			windowRect = GUI.Window (0, windowRect, windowFunc, "Pause Menu", customButton1);
		}
		if (option) 
		{
			windowRect = GUI.Window(0, windowRect, windowFuncOption, "Option",customButton1);
			//paused = false;
		}
	}
	
	private void windowFunc(int id)
	{
		if (GUILayout.Button("Resume",customButton))
		{
			GameObject.Find("FPSController").GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled=true;
			GameObject.Find("Samurai").GetComponent<EnemyModelMovement>().enabled=true;
			paused = false;
			
		}
		if (GUILayout.Button("Options",customButton))
		{
			option = true;
			//paused = false;
		}
		if (GUILayout.Button("Exit",customButton))
		{
			Application.LoadLevel("MainMenu");
		}
	}
	
	private void windowFuncOption(int id)
	{
		if (GUILayout.Button("Audio On",customButton))
		{
			AudioListener.pause = false;
			option = false;
			paused = true;
			
		}
		if (GUILayout.Button("Audio Off",customButton))
		{
			AudioListener.pause = true;
			option = false;
			paused = true;
		}
		if (GUILayout.Button ("Resolution", customButton)) 
		{

			string[] names = QualitySettings.names;
			GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
			GUILayout.FlexibleSpace();
			GUILayout.BeginHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.BeginVertical();
			for (int i = 0; i < names.Length; i++) {
				if (GUILayout.Button(names[i],GUILayout.Width(200)))
					QualitySettings.SetQualityLevel(i, true);
			}
			GUILayout.EndVertical();
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			GUILayout.FlexibleSpace();
			GUILayout.EndArea();
		}
	}
}