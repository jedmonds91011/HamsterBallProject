using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {
	
	public GameObject killAnimation;
	private float timer;
	private bool beenHit;
	private GameObject enemy;

	void Start()
	{
		timer = 0.0f;
		beenHit = false;
		//spawn = transform.position;
	}
	// Update is called once per frame
	void Update () 
	{
		if(beenHit)
		{
			if(timer % 5 < .2)
			{
				beenHit = false;
				enemy.collider.enabled = true;
			}
		}
		timer += Time.fixedDeltaTime;
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy" && !beenHit) 
		{
			enemy = other.gameObject;
			beenHit = true;

			Vector3 forceVector = -gameObject.rigidbody.velocity.normalized;	
			gameObject.rigidbody.velocity = Vector3.Reflect(enemy.transform.position, forceVector);

			damage ();
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Hurts" && !beenHit)
		{
			enemy = other.gameObject;
			beenHit = true;
			Vector3 forceVector = -gameObject.rigidbody.velocity.normalized;	
			gameObject.rigidbody.velocity = Vector3.Reflect(enemy.transform.position, forceVector*3);
			
			damage ();
		}
		else if(other.gameObject.tag == "Sweet Spot")
		{
			other.gameObject.SetActive(false);
		}


	}

	void damage()
	{
		Instantiate(killAnimation, transform.position, Quaternion.identity);
		GameManager.takeDamage ();
		enemy.collider.enabled = false;
		//transform.position = GameManager.getSpawn();
		//gameObject.GetComponentInChildren<Rigidbody> ().transform.position = GameManager.getSpawn ();
		
	}
}

