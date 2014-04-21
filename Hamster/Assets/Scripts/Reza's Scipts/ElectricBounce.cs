using UnityEngine;
using System.Collections;

public class ElectricBounce : MonoBehaviour {

	public GameObject character;
	public GameObject apllyForcetoThis;
	public Texture rubberTex;
	private float xForce;
	private float zForce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		xForce = character.rigidbody.velocity.x;
		zForce = character.rigidbody.velocity.z;
	}

	void OnTriggerEnter(Collider collision)
	{
		/*Vector3 oppositeForce = new Vector3 (character.rigidbody.velocity.x * -5, character.rigidbody.velocity.y, character.rigidbody.velocity.z * -5);
		Debug.Log("OPP FORCE: " + oppositeForce);
		Debug.Log("CURR Force: " + character.rigidbody.velocity);
		*/

		/*
		if (character.rigidbody.velocity.x > 0)
			{
			//xForce = Random.Range(-20f, -30f);
			//xForce = Random.Range(-20f, -10f);
				xForce = -20f;
			}
		else if (character.rigidbody.velocity.x < 0)
			{
			//xForce = Random.Range(10f, 20f);
			//xForce = Random.Range(20f, -0f);
				xForce = 20f;
			}

		yForce = .0f;
			
		if (character.rigidbody.velocity.z > 0)
			{
			//zForce = Random.Range(-20f, -10f);
			//zForce = Random.Range(-20f, -30f);
			zForce = -10f;
			}
		else if (character.rigidbody.velocity.z < 0)
			{
			//zForce = Random.Range(10f, 20f);
			//zForce = Random.Range(20f, 30f);
			zForce = 10f;

			}
			*/

		xForce *= -1;
		zForce *= -1;

		Vector3 oppositeForce = new Vector3(xForce, 0.0f, zForce); 

		//Debug.Log("OPP FORCE: " + oppositeForce);
		//Debug.Log("CURR Force: " + character.rigidbody.velocity);


		if (character.renderer.material.mainTexture != rubberTex)
			{
				apllyForcetoThis.rigidbody.AddForce(oppositeForce, ForceMode.Impulse);
			}
	}
}
