using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int currentScore;
	public static int highScore;

	public static int currentLevel = 0;
	public static int collectedPower = 0;

	public static int counter = 0;

	public static Vector3 spawn;

	private Rect pauseRect = new Rect(Screen.width/4, Screen.height/4, Screen.width/4, Screen.height/4);

	public Texture pauseScreen;

	private bool isPaused = false;

	void Update()
	{

		counter += 1;
		if(Input.GetKeyUp(KeyCode.Escape))
		{
			isPaused = !isPaused;

			if(isPaused)
			{
				Time.timeScale = 0;
				Screen.showCursor = true;
			}
			else
			{
				Time.timeScale = 1;
				Screen.showCursor = false;
			}
			//GUIHandler.OnGUI();
			//Application.Quit();

		}

	}

	void OnGUI()
	{		
		if (isPaused)
			pauseRect = GUI.Window (0, pauseRect, PauseMenu, "Pause Menu");

		// Set our coordinate group
		//GUI.BeginGroup (pauseRect);
		
		// draw stuff!
		//GUI.Box (pauseRect, GUIContent.none);
		//GUI.Label (stop, "Genre: Puzzle Platformer");
		//GUI.Label (go, "Mechanics: \n\tSlidy Movement \n\tCollectibles (Stars) \n\tDon't die!");
		
		
		// MUST NOT FORGET
		//GUI.EndGroup ();
		//GUI.DrawTexture (pauseRect, pauseScreen);
	}

	void PauseMenu(int windowId)
	{
		if(GUILayout.Button("Main Menu"))
		{
			isPaused = false;
			currentLevel = 0;
			Application.LoadLevel(0);
		}
		if(GUILayout.Button ("Restart"))
		{
			isPaused = false;
			Application.LoadLevel(currentLevel);


		}
		if(GUILayout.Button ("Quit"))
		{
			Application.Quit ();
		}
	}

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