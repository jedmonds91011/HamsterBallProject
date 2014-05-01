using UnityEngine;
using System.Collections;

public class GUIHandler : MonoBehaviour 
{
	// GUI rectangles
	public static Rect guiArea = new Rect(10, 10, 200, 128);
	public static Rect guiBG	 = new Rect(0,  0,  200, 128);
	public static Rect guiGenre  = new Rect(10, 10, 512, 20);
	public static Rect guiMechanics  = new Rect(10, 34, 512, 200);

	public static void OnGUI() 
	{
		// Set our coordinate group
		GUI.BeginGroup (guiArea);
		
		// draw stuff!
		GUI.Box (guiBG, GUIContent.none);
		GUI.Label (guiGenre, "Genre: Puzzle Platformer");
		GUI.Label (guiMechanics, "Mechanics: \n\tSlidy Movement \n\tCollectibles (Stars) \n\tDon't die!");

		
		// MUST NOT FORGET
		GUI.EndGroup ();
	}
}