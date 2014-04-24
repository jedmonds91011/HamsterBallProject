using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int currentScore;
	public static int highScore;

	public static int currentLevel = 0;
	public static int collectedPower = 0;
	public static int unlockedLevel;

	void Update()
	{
		Debug.Log (collectedPower);
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();

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
}