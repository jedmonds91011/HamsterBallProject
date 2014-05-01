using UnityEngine;

public class LaserWall : MonoBehaviour {
	
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
		
		/*
		if (transform.collider.isTrigger == false) 
		{
			counter += Time.fixedDeltaTime;

			if(counter > 5)
			{
				transform.collider.isTrigger = true;
				counter = 0;
			}
		}
		Debug.Log (transform.collider.isTrigger);
		*/
		
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
			
			forceVector = -character.rigidbody.velocity.normalized;
			//Debug.Log (forceVector);
			
			//Rigidbody Hamster = character.GetComponentInChildren<Rigidbody>();
			//Hamster.rigidbody.velocity = Vector3.Reflect(forceVector, forceVector);
			
			character.rigidbody.velocity = Vector3.Reflect(forceVector, forceVector);
			
			//Hamster.rigidbody.AddForce(forceVector);
			
			parentCollider.SetActive(true);
			
		}
		
	}
	/*
	void OnTriggerExit(Collider collider)
	{
		character.renderer.material.mainTexture = nonArmorTex;
		character.renderer.material.shader = nonArmorShade;
	}
	*/
	
}
