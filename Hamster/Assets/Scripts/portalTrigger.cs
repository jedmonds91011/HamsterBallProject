using UnityEngine;
using System.Collections;

public class portalTrigger : MonoBehaviour {

	private int power = GameManager.GetPower();

	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && power == 3) 
		{
			GameManager.CompleteLevel ();
		}
	}
}
