using UnityEngine;
using System.Collections;

public class portalTrigger : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter()
	{
		GameManager.CompleteLevel ();
	}
}
