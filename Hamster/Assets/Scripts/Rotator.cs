using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public float rotateSpeed;
	// Update is called once per frame

	void Update () 
	{
		transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
	
	}
}
