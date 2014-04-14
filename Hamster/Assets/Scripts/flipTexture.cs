using UnityEngine;
using System.Collections;

public class flipTexture : MonoBehaviour {

	
	float scaleX = 10f;
	// Update is called once per frame
	void Update () 
	{
		float offset = Time.time * scaleX;
		renderer.material.mainTextureOffset = new Vector2 (0,offset);
	
	}
}
