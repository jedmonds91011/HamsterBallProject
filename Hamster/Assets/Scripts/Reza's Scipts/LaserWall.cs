using UnityEngine;
using System.Collections;

public class LaserWall : MonoBehaviour {

	public GameObject character;
	public Texture armorTex;
	private Texture nonArmorTex;
	private Shader nonArmorShade;

	// Use this for initialization
	void Start () 
	{
		nonArmorTex = character.renderer.material.mainTexture;
		nonArmorShade = character.renderer.material.shader;
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	void OnTriggerEnter(Collider collider)
	{
		if( character.renderer.material.mainTexture != armorTex )
			{
			Debug.Log("You Died");
			character.SetActive(false);
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
