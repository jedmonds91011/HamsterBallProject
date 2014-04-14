using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float moveSpeed;
	public float maxSpeed; 
	public GameObject killAnimation;

	private Vector3 input;
	private Vector3 spawn;
	// Use this for initialization
	void Start () 
	{
		spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		if (rigidbody.velocity.magnitude < maxSpeed) 
		{
			rigidbody.AddForce (input * moveSpeed);
		}

		if (transform.position.y < -2) 
		{
			Die();
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			Die();
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


	void Die()
	{
		Instantiate(killAnimation, transform.position, Quaternion.identity);
		transform.position = spawn;
	}
}
