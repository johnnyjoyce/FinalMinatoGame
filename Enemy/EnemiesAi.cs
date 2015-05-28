﻿using UnityEngine;
using System.Collections;

public class EnemiesAi : MonoBehaviour {

	public Transform player;
	public float playerDistance;
	public float rotationDamping;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		playerDistance = Vector3.Distance (player.position, transform.position);

		if (playerDistance < 15f) {
			lookAtPlayer();
		}
		if (playerDistance < 12f) {
			if(playerDistance > 2f){
				chase ();
			}
			else if(playerDistance < 2f){
				attack ();
			}
		}
	}

	void lookAtPlayer(){
		Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);

		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationDamping);
	}

	void chase(){
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void attack(){
		gameObject.GetComponent<EnemyAttacker> ().Attack ();
	}
}
