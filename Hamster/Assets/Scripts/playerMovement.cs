using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float moveSpeed;
	public float maxSpeed; 

	private Vector3 input;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Debug.Log (GameManager.GetPower ());
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		if (rigidbody.velocity.magnitude < maxSpeed) 
		{
			rigidbody.AddForce (input * moveSpeed * Time.deltaTime);
		}
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Goal" && GameManager.GetPower() == 3)
		{
			GameManager.CompleteLevel();
		}
		if(other.gameObject.tag == "Collectible")
		{
			Destroy(other.gameObject);
			GameManager.IncrementPower();
		}
	}
}
