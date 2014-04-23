using UnityEngine;
using System.Collections;

public class ButtonSwitch : MonoBehaviour 
{
	public Light spot;
	public GameObject[] triggers;
	private Color lightColor;
	private bool hasSwitched;

	void Start()
	{
		lightColor = Color.blue;
		hasSwitched = false;
	}

	void OnTriggerEnter()
	{
		if (!hasSwitched)
		{
			hasSwitched = true;
			spot.color = lightColor;
			transform.Translate(0.0f, -0.2f, 0.0f);
			foreach (GameObject item in triggers)
			{
				item.SetActive(false);
			}
		}
	}

	
}
