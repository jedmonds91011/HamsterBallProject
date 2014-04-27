using UnityEngine;
using System.Collections;

public class ElectricWall : MonoBehaviour {

	public GameObject character;
	public Texture armorTex;
	public GameObject parentCollider;

	private Texture nonArmorTex;
	private Vector3 forceVector;
	private float counter;
	
	// Use this for initialization
	void Start () 
	{
		nonArmorTex = character.renderer.material.mainTexture;
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
		
		if(character.renderer.material.mainTexture != armorTex && collider.tag == "Player")
		{

			parentCollider.SetActive(true);
			forceVector = -character.rigidbody.velocity.normalized * 3000;
			
			Rigidbody Hamster = character.GetComponentInChildren<Rigidbody>();
			
			Hamster.rigidbody.AddForce(forceVector);

			
		}
		
	}

}
