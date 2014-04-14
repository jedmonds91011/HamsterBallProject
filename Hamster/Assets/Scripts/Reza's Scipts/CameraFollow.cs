using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	Vector3 offset = Vector3.zero;
	public int zOffset = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (offset == Vector3.zero) {
			offset = transform.position - player.transform.position;
		}

		if( player.activeSelf == true )
			{
			transform.position = new Vector3 (player.transform.position.x, transform.position.y, player.transform.position.z - zOffset);
			}
	}
}
