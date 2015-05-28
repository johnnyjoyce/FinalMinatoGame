using UnityEngine;
using System.Collections;

public class SpawnKnife : MonoBehaviour
{
	public Transform knife;	 // The knife object that spawns
	public Transform hand;   // The position of the Hand that throws the knife
	public Transform player; // The position of the player
	public Transform actualknife;
	
	Transform temp;	 // Temp object to spawn the bullet 
	float tempX;     // Temp variable used to spawn the player at the X axis
	float tempZ;     // Temp variable used to spawn the player at the Z axis
	float tempY = 3; // Height the player spawns in on
	
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) // When the player presses the left button
		{
			if (!GameObject.Find("Knife(Clone)")) // If the knife clone doesn't exist in the 
			{
				temp = (Transform)Instantiate (knife, hand.transform.position, Quaternion.identity); // Spawns the knife at the hands position and orientation
				
				temp.GetComponent<Rigidbody>().AddForce(transform.forward * 3000); // Adds force to the knives rigidbody so it flies

				actualknife.gameObject.GetComponent<Renderer>().enabled = false;
			}
			if(Input.GetKey(KeyCode.R)){
				GetComponent<Renderer>().enabled = false;
			}
		}
		
		if (Input.GetKeyDown(KeyCode.E) && GameObject.Find("Knife(Clone)") ) // If the player presses E and the knife exists (flying)
		{
			tempX = temp.transform.position.x; 
			tempZ = temp.transform.position.z;
			
			player.transform.position = new Vector3(tempX, 90, tempZ); // Teleport player to the knives position with a set height
			
			Destroy(temp.gameObject);
			actualknife.gameObject.GetComponent<Renderer>().enabled = true;

		}
		
	}// Constantly updating
	
}