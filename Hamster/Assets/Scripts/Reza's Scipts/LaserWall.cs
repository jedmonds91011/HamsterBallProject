using UnityEngine;

public class LaserWall : MonoBehaviour {
	
	public GameObject character;
	public Texture armorTex;
	public GameObject parentCollider;
	
	private Texture nonArmorTex;
	private Vector3 forceVector;
	private float counter;
	private bool canDamage;
	
	// Use this for initialization
	void Start () 
	{
		nonArmorTex = character.renderer.material.mainTexture;
		counter = 0;
		parentCollider.SetActive (false);
		canDamage = true;
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
				canDamage = true;
				counter = 0;
			}
		}
	}
	
	void OnTriggerEnter(Collider collider)
	{
		
		if(character.renderer.material.mainTexture != armorTex && collider.tag == "Player")
		{
			
			forceVector = -character.rigidbody.velocity.normalized;
			
			character.rigidbody.velocity = Vector3.Reflect(gameObject.transform.position, forceVector);
			
			//Hamster.rigidbody.AddForce(forceVector);
			
			parentCollider.SetActive(true);
			if(canDamage)
			{
				GameManager.takeDamage();
				canDamage = false;
			}
			
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
