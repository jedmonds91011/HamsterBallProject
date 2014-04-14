using UnityEngine;
using System.Collections;

public class TextureChanger : MonoBehaviour {

	public GameObject character;
	public Texture newTexture;
	public Texture oldTexture;

	//private Texture tex = 

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void OnTriggerEnter (Collider collider) 
	{
		oldTexture = character.renderer.material.mainTexture;
		character.renderer.material.mainTexture = newTexture;
	}

}
