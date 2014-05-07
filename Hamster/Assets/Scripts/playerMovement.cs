using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float moveSpeed;
	public float maxSpeed; 


	private GameObject Ball;
	private Vector3 input;
	private float inputMagnitude;
	private GameObject parentBall;


	void Start()
	{
		GameManager.setSpawn (transform.position);
		parentBall = GameObject.Find ("Ball");

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		inputMagnitude = rigidbody.velocity.magnitude;
		

		if (inputMagnitude < maxSpeed) 
		{
			rigidbody.AddForce (input * moveSpeed);
		}

	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Collectible")
		{
			
			GameManager.IncrementPower();
			
			Destroy(other.gameObject);
		}

	}

	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			gameObject.transform.position = parentBall.transform.position;
		}
	}
}
