using UnityEngine;
using System.Collections;

public class LightControl : MonoBehaviour {

	public GameObject light;
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
			light.SetActive(true);
			}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == character.name)
			{
			light.SetActive(false);
			}
	}
}
