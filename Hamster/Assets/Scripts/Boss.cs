using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	public GameObject[] weakSpots;
	public GameObject thisParent; 
	
	private int currentStage;
	private bool isInvincible;
	private Color active;



	// Use this for initialization
	void Start ()
	{
		currentStage = 0;
		active = Color.green;
		SetWeakPoint (weakSpots [currentStage]);

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!weakSpots[currentStage].activeSelf)
		{
			currentStage += 1;
			SetWeakPoint (weakSpots [currentStage]);
		}

		if (currentStage > 3)
		{
			gameObject.GetComponent<Patrol>().enabled = false;
		}
		
	}


	void SetWeakPoint(GameObject activeSpot)
	{
		Light currentLight = activeSpot.GetComponentInChildren<Light> ();
		activeSpot.tag = "Sweet Spot";
		currentLight.color = active;

	}

}
