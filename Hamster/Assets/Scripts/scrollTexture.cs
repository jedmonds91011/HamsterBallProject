using UnityEngine;
using System.Collections;

public class scrollTexture : MonoBehaviour {

	
	public float scaleX;
	private int direction = 1;
	private int count = 0;
	// Update is called once per frame
	void Update () 
	{
		if (count > 3)
			direction *= -1;

		float offset = Time.time * scaleX * direction;
		renderer.material.mainTextureOffset = new Vector2 (-offset, offset);
	
		count += 1;
	}
}
