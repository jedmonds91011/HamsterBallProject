using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {
	
	public GameObject killAnimation;

	private Vector3 spawn;

	void Start()
	{
		spawn = transform.position;
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
		}
	}

	void Die()
	{
		Instantiate(killAnimation, transform.position, Quaternion.identity);
		transform.position = spawn;
	}
}
