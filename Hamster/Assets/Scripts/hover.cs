using UnityEngine;
using System.Collections;

public class hover : MonoBehaviour {

	public int duration;

	private int direction;
	private float counter;


	private Vector3 initialPosition;

	void Start()
	{
		direction = 1;
		initialPosition = transform.position;
	}

	// Update is called once per frame
	void Update () 
	{
		counter += 1;

		if (counter > duration) 
		{
			direction *= -1;
			counter = 1;
		}

		transform.position = new Vector3 (transform.position.x, gameObject.transform.position.y + direction * Mathf.Sin (Time.deltaTime), transform.position.z);
		//gameObject.transform.position.y = Mathf.Sin (counter); 
		//transform.rigidbody.AddForce (Vector3.up * strength);

		//timer += (Time.deltaTime) * 0.5f;
		//transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y * (Mathf.Sin (counter)), gameObject.transform.position.z);

		//float yMotion = Mathf.Sin (Time.time) * -0.5f + 1;
		//transform.Translate (0, yMotion, 0, Space.Self);

	}
}
