using UnityEngine;
using System.Collections;

public class MagnetWall : MonoBehaviour {

	public GameObject character;
	public Texture cannotPass;

	void OnCollideEnter(Collider collider)
	{
		if (character.renderer.material.mainTexture != cannotPass) {
						collider.isTrigger = true;
				} 
		else
			collider.isTrigger = false;


	}
}
