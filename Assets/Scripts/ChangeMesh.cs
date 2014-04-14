using UnityEngine;
using System.Collections;

public class ChangeMesh : MonoBehaviour {

	public GameObject target;
	public Texture original;
	public Texture replacement; 
	private Color itemColor;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			if(target.renderer.material.mainTexture == original)
			{
				target.renderer.material.mainTexture = replacement;
			}
			else
			{
				target.renderer.material.mainTexture = original;

			}
	
		}
	}
}