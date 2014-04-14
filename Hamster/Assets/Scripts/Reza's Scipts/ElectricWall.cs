using UnityEngine;
using System.Collections;

public class ElectricWall : MonoBehaviour {

	public GameObject character;
	public Texture armorTex;
	public Texture nonArmor;
	
	// Use this for initialization
	void Start () 
	{
		nonArmor = character.renderer.material.mainTexture;
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	
	void OnTriggerEnter(Collider collider)
	{
		if( character.renderer.material.mainTexture != armorTex )
		{
			character.rigidbody.AddForce(Vector3.forward * -100f * Time.deltaTime);
		}
	}
	
	void OnTriggerExit(Collider collider)
	{
		character.renderer.material.mainTexture = nonArmor;
	}
}
