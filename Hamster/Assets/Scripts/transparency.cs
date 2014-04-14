using UnityEngine;
using System.Collections;

public class transparency : MonoBehaviour {

	public GameObject item;
	public float transperancy;
	private Color itemColor;

	void Start()
	{
		itemColor = item.renderer.material.color;
	}

	void OnTriggerEnter()
	{
		itemColor.a = transperancy;
		item.renderer.material.color = itemColor; 
	}
}