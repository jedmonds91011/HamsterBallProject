using UnityEngine;
using System.Collections;

public class hover : MonoBehaviour {
	float timer = 0.0f;

	// Update is called once per frame
	void FixedUpdate () 
	{

		timer += (Time.deltaTime) * 0.5f;
		transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y * (Mathf.Sin (timer)), gameObject.transform.position.z);

		//float yMotion = Mathf.Sin (Time.time) * -0.5f + 1;
		//transform.Translate (0, yMotion, 0, Space.Self);

	}
}
