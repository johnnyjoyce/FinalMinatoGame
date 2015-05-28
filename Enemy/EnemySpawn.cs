using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public PlayerHealth  currentHealth;
	public GameObject enemy;
	public float spawnTime = 3f;
	public Transform[] spwnPoints;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn(){
		/*if (currentHealth <= 0f) {
			return;
		}*/

		//int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		//Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
}
