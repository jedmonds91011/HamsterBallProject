﻿using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {

	void Update () 
	{
		transform.Rotate (new Vector3(15 ,30, 45) * Time.deltaTime);
	}

	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			
			GameManager.IncrementPower();
			Destroy(gameObject);
		}
		
	}
}
