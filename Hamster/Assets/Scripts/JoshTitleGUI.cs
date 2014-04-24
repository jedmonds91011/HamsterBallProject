using UnityEngine;
using System.Collections;

public class JoshTitleGUI : MonoBehaviour
{
	//Declaring local variables
	Rect newButton = new Rect(Screen.width/2 - 250, Screen.height/4 + 400, 100, 64);
	Rect helpButton =  new Rect(Screen.width/2 - 50, Screen.height/4 + 400, 100, 64);
	Rect quitButton =  new Rect(Screen.width/2 + 150, Screen.height/4 + 400, 100, 64);
	Rect backButton = new Rect(Screen.width/2, Screen.height - 100 , 100, 64);
	Rect helpRect = new Rect (0, 25, Screen.width, Screen.height); 
	Rect titleRect = new Rect (Screen.width/4, Screen.height/8, Screen.width/2, Screen.height/2);


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
