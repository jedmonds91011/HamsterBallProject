using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {
	
	public GameObject killAnimation;

	void Start()
	{
		//spawn = transform.position;
	}
	// Update is called once per frame
	void Update () 
	{

		if (transform.position.y < -2) 
		{
			Die();
		}
	
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			Die ();
			rigidbody.velocity = Vector3.zero;
		}
	}

	void Die()
	{
		Instantiate(killAnimation, transform.position, Quaternion.identity);
		transform.position = GameManager.getSpawn();
	}
}
