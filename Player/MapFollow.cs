using UnityEngine;
using System.Collections;

public class MapFollow : MonoBehaviour {

	public GameObject Player = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(Player.transform.position.x,this.transform.position.y,Player.transform.position.z);
	
	}
}
