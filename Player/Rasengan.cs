using UnityEngine;
using System.Collections;

//[RequireComponent(typeof (CharacterController))]
[RequireComponent(typeof (AudioSource))]

public class Rasengan : MonoBehaviour {

	public AudioSource audio; //Create an audiosource on the button and drag it on
	public AudioClip buttonSound; //Put sound clip here

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Renderer>().enabled = false;
		if (Input.GetKey (KeyCode.R)) {
			GetComponent<Renderer>().enabled = true;
			//WaitAndDestroy();

			audio.Play ();
			//SpawnKnife.Destroy(true);
			//audio.loop = true;
			//AudioClip.PlayOneShot(Rasengan, 0.7f);
		} 

		else {
			GetComponent<Renderer>().enabled = false;
		}
	
	}
}
