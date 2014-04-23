using UnityEngine;
using System.Collections;

public class TitleGUI : MonoBehaviour
{
	//Declaring local variables
	Rect newButton = new Rect(600, 700, 100, 64);
	Rect helpButton = new Rect(800, 700, 100, 64);
	Rect quitButton = new Rect(1000, 700, 100, 64);
	Rect backButton = new Rect(800, 800, 100, 64);
	Rect helpRect = new Rect (50, 20, 1200, 1200); 
	Rect titleRect = new Rect (200, 20, 1200, 300);


	public Texture newButtonTexture;
	public Texture helpButtonTexture;
	public Texture quitButtonTexture;
	public Texture backButtonTexture;
	public Texture helpImg;
	public Texture titleImg;
	public GameObject objects;
	public Vector3 objectLoc;
	public Vector3 beginLoc;

	private bool helpFlag = false;

	void Start()
	{
		beginLoc = objects.transform.position;
	}

	void OnGUI()
	{
		if(helpFlag == false)
		{
			GUI.DrawTexture(titleRect, titleImg, ScaleMode.ScaleToFit, true, 0.0f);
			if(!newButtonTexture)
			{
				Debug.LogError("Please assign a texture on the inspector");
				return;
			}	

			if(!helpButtonTexture)
			{
				Debug.LogError("Please assign a texture on the inspector");
				return;
			}

			if(!quitButtonTexture)
			{
				Debug.LogError("Please assign a texture on the inspector");
				return;
			}
			
			if(GUI.Button(newButton, newButtonTexture))
			{
				GameManager.CompleteLevel();
				Debug.Log ("Clicked the button!");
			}

			if(GUI.Button(helpButton, helpButtonTexture))
			{
				Debug.Log ("Clicked the button!");
				helpFlag = true;
			}

			if(GUI.Button(quitButton, quitButtonTexture))
			{
				Debug.Log ("Clicked the button!");
				Application.Quit();
			}
		}
		else
		{
			if(!helpImg)
			{
				Debug.LogError("Please assign a texture on the inspector");
			}
			objects.transform.position = objectLoc;
			GUI.DrawTexture(helpRect, helpImg, ScaleMode.ScaleToFit, true, 0.0f);
			//GUI.DrawTexture (objectRect, objectImg, ScaleMode.ScaleToFit, true, 0.0f);

			if(!backButtonTexture)
			{
				Debug.LogError("Please assign a texture on the inspector");
				return;
			}

			if(GUI.Button(backButton, backButtonTexture))
			{
				Debug.Log ("Clicked the button!");
				helpFlag = false;
				objects.transform.Translate(beginLoc);
			}

		}
	}
}
