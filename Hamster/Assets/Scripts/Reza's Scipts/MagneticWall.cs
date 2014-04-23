using UnityEngine;
using System.Collections;

public class MagneticWall : MonoBehaviour {

	public GameObject character;
	public Texture killTex;
	
	void OnCollisionEnter()
	{
		if( character.renderer.material.mainTexture == killTex )
			{
			Debug.Log("You Died");
			//character.SetActive(false);
			character.rigidbody.AddExplosionForce(1000.0f, gameObject.transform.position, 100.0f);
			}
	}
}
