using UnityEngine;
using System.Collections;

public class MagWall : MonoBehaviour {
	public GameObject character;
	public Texture armorTex;
	public GameObject parentCollider;
	
	private Vector3 forceVector;
	private float counter;
	
	// Use this for initialization
	void Start () 
	{
		counter = 0;
		parentCollider.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (parentCollider.activeSelf)
		{
			counter += Time.fixedDeltaTime;
			
			if(counter > 2)
			{
				parentCollider.SetActive (false);
				counter = 0;
			}
		}
		
	}
	
	void OnTriggerEnter(Collider collider)
	{
		
		if(collider.renderer.material.mainTexture == armorTex && collider.tag == "Player")
		{
			
			//forceVector = -character.rigidbody.velocity.normalized;
			//Debug.Log (forceVector);
			
			//Rigidbody Hamster = character.GetComponentInChildren<Rigidbody>();
			//Vector3 HamsterForce = -Hamster.rigidbody.velocity.normalized;
			//Hamster.rigidbody.velocity = Vector3.Reflect(HamsterForce, HamsterForce);
			
			//character.rigidbody.velocity = Vector3.Reflect(forceVector, forceVector*3);
			//character.rigidbody.AddForce(forceVector);
			
			//Hamster.rigidbody.AddRelativeForce(HamsterForce);
			
			parentCollider.SetActive(true);
			
		}
		
	}
}

