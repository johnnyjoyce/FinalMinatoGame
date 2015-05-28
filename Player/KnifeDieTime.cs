using UnityEngine;
using System.Collections;

public class KnifeDieTime : MonoBehaviour
{
	void Start () 
	{
		StartCoroutine(KillKnife()); // When the knife spawns do this
	}
	
	IEnumerator KillKnife()
	{
		yield return new WaitForSeconds(2); // Wait for 2 seconds
		
		if(gameObject != null) // Destroy the knife if it exists
		{
			Destroy (gameObject);
		}
	}
}