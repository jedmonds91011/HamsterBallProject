using UnityEngine;
using System.Collections;

public class ElectricBounce : MonoBehaviour {

	public GameObject character;
	public GameObject apllyForcetoThis;
	public Texture rubberTex;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision)
	{
		/*Vector3 oppositeForce = new Vector3 (character.rigidbody.velocity.x * -5, character.rigidbody.velocity.y, character.rigidbody.velocity.z * -5);
		Debug.Log("OPP FORCE: " + oppositeForce);
		Debug.Log("CURR Force: " + character.rigidbody.velocity);
		*/
		float xForce = 0;
		float yForce = 0;
		float zForce = 0;

		if (character.rigidbody.velocity.x > 0)
			{
			xForce = Random.Range(-20f, -30f);
			}
		else if (character.rigidbody.velocity.x < 0)
			{
			xForce = Random.Range(20f, -0f);
			}

		yForce = .25f;
			
		if (character.rigidbody.velocity.z > 0)
			{
			zForce = Random.Range(-20f, -30f);
			}
		else if (character.rigidbody.velocity.z < 0)
			{
			zForce = Random.Range(20f, 30f);
			}

		Vector3 oppositeForce = new Vector3(xForce, yForce, zForce); 

		Debug.Log("OPP FORCE: " + oppositeForce);
		Debug.Log("CURR Force: " + character.rigidbody.velocity);


		if (character.renderer.material.mainTexture != rubberTex)
			{
			apllyForcetoThis.rigidbody.AddForce(oppositeForce, ForceMode.Impulse);
			}
	}
}
