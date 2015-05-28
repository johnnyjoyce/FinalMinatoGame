using UnityEngine;
using System.Collections;

public class EnemyModelMovement : MonoBehaviour {

	GameObject Player;
	public Transform player2;
	NavMeshAgent mov;
	bool playerInRange;
	public int attackDamage = 10;
	PlayerHealth playerHealth;

	// Use this for initialization
	void Awake () {
		player2 = GameObject.FindGameObjectWithTag ("Player").transform;
		Player = GameObject.FindGameObjectWithTag ("Player");
		mov = GetComponent <NavMeshAgent> ();
	
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == Player) 
		{
			playerInRange = false;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == Player) 
		{
			playerInRange = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (player2.position, transform.position);

		mov.SetDestination (player2.position);

		if (playerInRange == true) 
		{
			Attack();
		}
	
	}

	void Attack(){
		//playerHealth.TakeDamage (attackDamage);
	
	}
}
