using UnityEngine;
using System.Collections;

public class LightControl : MonoBehaviour {

	public GameObject objLight;
	public GameObject character;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject.name == character.name)
			{
			objLight.SetActive(true);
			}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == character.name)
			{
			objLight.SetActive(false);
			}
	}
}
