using UnityEngine;
using System.Collections;

public class portalTrigger : MonoBehaviour {

	//private int power = GameManager.GetPower();

	void Start()
	{
		gameObject.GetComponent<Rotator> ().enabled = false;
	}

	void Update()
	{
		if(GameManager.GetPower () == 3)
		{
			gameObject.GetComponent<Rotator>().enabled = true;
		}
	}

	/*
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && power == 3) 
		{
			GameManager.CompleteLevel ();
		}
		
	}
	*/
}
