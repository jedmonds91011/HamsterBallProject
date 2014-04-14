using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float moveSpeed;
	public float maxSpeed; 

	private Vector3 input;
	
	// Update is called once per frame
	void Update () 
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		if (rigidbody.velocity.magnitude < maxSpeed) 
		{
			rigidbody.AddForce (input * moveSpeed);
		}
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Goal")
		{
			GameManager.CompleteLevel();
		}

		if(other.gameObject.tag == "Collectible")
		{
			Destroy(other.gameObject);
		}
	}
}
