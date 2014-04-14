using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public KeyCode forward = KeyCode.W;
	public KeyCode backward = KeyCode.S;
	public KeyCode left = KeyCode.A;
	public KeyCode right = KeyCode.D;

	public float moveForce = 4.0f;

	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
		if( Input.GetKey(forward) ) 
			{
			rigidbody.AddForce(Vector3.forward * moveForce * Time.deltaTime);
			}
		if( Input.GetKey(backward) )
			{
			rigidbody.AddForce(Vector3.forward * -moveForce * Time.deltaTime);
			}
		if( Input.GetKey(right) ) 
			{
			rigidbody.AddForce(Vector3.right * moveForce * Time.deltaTime);
			}
		if( Input.GetKey(left) )
			{
			rigidbody.AddForce(Vector3.right * -moveForce * Time.deltaTime);
			}
	}
}
