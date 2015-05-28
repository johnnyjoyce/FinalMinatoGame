using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	
	public int maxHealth = 100;
	public float currentHealth = 100;
	public GameObject Player;	
	public float healthBarLength;
	public float regeneration = 5;

	// Use this for initialization
	void Start () {
		healthBarLength = Screen.width / 2;	
		//InvokeRepeating ("Regeneration", 1, 0.1f);
		}
	
	// Update is called once per frame
	void Update () {
		AddjustCurrentHealth (0);
		if (currentHealth <= 0) {
			Application.LoadLevel(0);
		}
		if (currentHealth < maxHealth) {
			currentHealth += regeneration * Time.deltaTime;
		}
	}
	
	void OnGUI(){
		GUI.Box (new Rect (10, 10, healthBarLength, 20), currentHealth + "/" + maxHealth);
	}
	
	public void AddjustCurrentHealth(int adj){
		currentHealth += adj;
		
		if (currentHealth < 0)
			currentHealth = 0;
		
		if (currentHealth > maxHealth)
			currentHealth = maxHealth;
		
		if (maxHealth < 1)
			maxHealth = 1;
		
		healthBarLength = (Screen.width / 2) * (currentHealth / (float)maxHealth);
	}
}