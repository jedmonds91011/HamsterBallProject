﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int currentScore;
	public static int highScore;

	public static int currentLevel = 0;
	public static int collectedPower = 0;

	public static int counter = 0;
	public static int damage = 0;

	public static Vector3 spawn;

	public Texture[] guiText;
	public Texture[] damageTextures;
	public Texture[] pauseScreen;

	private Rect pauseRect = new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2);
	private Rect loseRect = new Rect(Screen.width/4+1, Screen.height/4, Screen.width/2, Screen.height/2);
	private Rect gameGUI;
	private Rect damageGUI;

	private bool isPaused;
	private bool isDead;


	void Start()
	{
		gameGUI = new Rect (0, Screen.height - guiText[0].height, guiText[0].width, guiText[0].height);
		isPaused = false;
		isDead = false;
	}

	void Update()
	{

		//counter += Time.fixedDeltaTime;
		if(Input.GetKeyUp(KeyCode.Escape) && !isDead)
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
		}

		if (damage > 3 && !isDead)
		{
			Time.timeScale = 0;
			Screen.showCursor = true;
			isDead = true;
		}
	}

	void OnGUI()
	{	
		if (isDead)
		{
			loseRect = GUI.Window (1, loseRect, PauseMenu, pauseScreen[4]);
		}

		else if (isPaused)
		{
			pauseRect = GUI.Window (0, pauseRect, PauseMenu, pauseScreen[0]);

		}

		else
		{
			GUI.BeginGroup (gameGUI, guiText[collectedPower]);
			GUI.DrawTexture (new Rect (96, 25, 128, 128), damageTextures [damage]);
			GUI.EndGroup ();
		}


	}

	void PauseMenu(int windowId)
	{
		GUI.FocusWindow (windowId);
		GUILayout.FlexibleSpace ();

		if(GUILayout.Button(pauseScreen[1]))
		{
			currentLevel = 0;
			Application.LoadLevel(0);
			Time.timeScale = 1;
			isDead = false;
		}
		if(GUILayout.Button (pauseScreen[2]))
		{
			Application.LoadLevel(currentLevel);
			Time.timeScale = 1;
			isDead = false;

		}
		if(GUILayout.Button (pauseScreen[3]))
		{
			Application.Quit ();
		}
		GUILayout.FlexibleSpace ();
	}


	public static void CompleteLevel()
	{
		currentLevel += 1;
		collectedPower = 0;
		Time.timeScale = 1;
		damage = 0;
		Application.LoadLevel (currentLevel);

	}

	public static void IncrementPower()
	{
		collectedPower += 1;
		if(collectedPower > 3)
			collectedPower = 3;
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
	public static void takeDamage()
	{
		damage += 1;
	}

}