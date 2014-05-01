using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int currentScore;
	public static int highScore;

	public static int currentLevel = 0;
	public static int collectedPower = 0;

	public static int counter = 0;

	public static Vector3 spawn;

	private Rect pauseRect = new Rect(Screen.width/2, Screen.height/2, Screen.width/4, Screen.height/4);
	public Texture pauseScreen;

	private bool isPaused = false;

	void Update()
	{

		counter += 1;
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			if(!isPaused)
			{
				Time.timeScale = 0;
				isPaused = true;
				Screen.showCursor = true;
			}
			else
			{
				Time.timeScale = 1;
				isPaused = false;
				Screen.showCursor = false;
			}
			//GUIHandler.OnGUI();
			//Application.Quit();

		}

	}
	/*
	void OnGUI()
	{		// Set our coordinate group
		GUI.BeginGroup (pauseRect);
		
		// draw stuff!
		GUI.Box (pauseRect, GUIContent.none);
		//GUI.Label (guiGenre, "Genre: Puzzle Platformer");
		//GUI.Label (guiMechanics, "Mechanics: \n\tSlidy Movement \n\tCollectibles (Stars) \n\tDon't die!");
		
		
		// MUST NOT FORGET
		GUI.EndGroup ();
		//GUI.DrawTexture (pauseRect, pauseScreen);
	}
	*/

	public static void CompleteLevel()
	{
		currentLevel += 1;
		collectedPower = 0;
		Application.LoadLevel (currentLevel);
	}

	public static void IncrementPower()
	{
		collectedPower += 1;
	}
	public static int GetPower()
	{
		return collectedPower;
	}

	public static int getCounter()
	{
		return counter;
	}
	public static Vector3 getSpawn()
	{
		return spawn;
	}
	public static void setSpawn( Vector3 currentLocation)
	{
		spawn = currentLocation;
	}
}