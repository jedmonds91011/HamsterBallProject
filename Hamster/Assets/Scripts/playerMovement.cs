using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float moveSpeed;
	public float maxSpeed; 
	public AudioClip[] soundClips;


	private Vector3 input;
	private float inputMagnitude;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		inputMagnitude = rigidbody.velocity.magnitude;

		/*
		if (inputMagnitude > 2.0f)
		{
			audio.Play();
		}
		else
		{
			audio.Stop();
		}
		*/
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

			Destroy(other.gameObject);
			GameManager.IncrementPower();
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
	}
}
