using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (this);	//Tells game when running not to destroy this game object on load

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SaveCharacter(){
		//PlayerPrefs.SetString("Player Name", );

	}

	void LoadCharacter(){

	}
}
