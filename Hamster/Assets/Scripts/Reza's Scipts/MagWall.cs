using UnityEngine;
using System.Collections;

public class MagWall : MonoBehaviour {

	public GameObject character;
	public Texture killTex;

	// Update is called once per frame
	void Update () 
	{
	}

	void OnTriggerEnter()
	{
		if( character.renderer.material.mainTexture == killTex )
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
