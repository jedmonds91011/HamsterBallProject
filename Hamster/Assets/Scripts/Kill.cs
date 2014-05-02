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
			rigidbody.velocity = Vector3.zero;
			Die ();

		}
	}

	void Die()
	{
		Instantiate(killAnimation, transform.position, Quaternion.identity);
		transform.position = GameManager.getSpawn();
		gameObject.GetComponentInChildren<Rigidbody> ().transform.position = GameManager.getSpawn ();

	}
}
