using UnityEngine;
using System.Collections;

public class HelpGUI : MonoBehaviour 
{
	//Declaring local variables
	Rect titleButton = new Rect(470, 200, 100, 64);
	public Texture titleButtonTexture;
		
	void OnGUI()
	{
		if(!titleButtonTexture)
		{
			Debug.LogError("Please assign a texture on the inspector");
			return;
		}	
				
		if(GUI.Button(titleButton, titleButtonTexture))
		{
			Debug.Log ("Clicked the button!");
			Application.LoadLevel("titlescene");
		}
	}
	
}
