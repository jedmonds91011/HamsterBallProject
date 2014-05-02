using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float moveSpeed;
	public float maxSpeed; 
	public AudioClip[] soundClips;


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
		string itemTag = other.gameObject.tag;

		if(itemTag == "Goal" && GameManager.GetPower() == 3)
		{
			GameManager.CompleteLevel();
		}

		else if(itemTag == "Collectible")
		{
			audio.clip = soundClips[0];
			audio.PlayOneShot(audio.clip);

			GameManager.setSpawn(transform.position);
			GameManager.IncrementPower();

			Destroy(other.gameObject);
		}
		else if(itemTag == "Switch")
		{
			audio.clip = soundClips[2];
			audio.PlayOneShot(audio.clip);
		}
		else if(itemTag == "Change Ball")
		{
			audio.clip = soundClips[1];
			audio.PlayOneShot(audio.clip);
		}
		else if (itemTag == "Electric")
		{
			audio.clip = soundClips[3];
			audio.PlayOneShot(audio.clip);
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
