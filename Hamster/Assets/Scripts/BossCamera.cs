using UnityEngine;
using System.Collections;

public class BossCamera : MonoBehaviour {

	private Vector3 offset;
	public GameObject boss;
	public GameObject player;
	// Use this for initialization
	void Start () 
	{
		offset = new Vector3 (0, 10, -20);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.position = player.transform.position + offset;
		transform.LookAt (player.transform);
		//transform.LookAt (Vector3.up);

	}
}
