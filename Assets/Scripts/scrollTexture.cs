using UnityEngine;
using System.Collections;

public class scrollTexture : MonoBehaviour {

	
	float scaleX = 1.5f;
	// Update is called once per frame
	void Update () 
	{

		float offset = Time.time * scaleX;
		renderer.material.mainTextureOffset = new Vector2 (0,-offset);
	
	}
}
