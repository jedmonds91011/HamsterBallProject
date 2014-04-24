using UnityEngine;
using System.Collections;

public class ActivatePortal : MonoBehaviour {
	
	public GameObject[] powerSources;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < 3; i++) 
		{
			powerSources[i].SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		int currentPower = GameManager.GetPower ()-1;
		if(!powerSources[currentPower].activeSelf)
		{
			powerSources[currentPower].SetActive(true);
		}
	
	}
}
