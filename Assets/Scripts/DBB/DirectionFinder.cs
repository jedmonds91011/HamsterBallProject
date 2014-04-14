using UnityEngine;
using System.Collections;

// Simple 3d math vector demo
// Computes the direction from us to a target object
// - reports various stats based on direction
//	- Direction to target
//	- Distance to target
//	- Angle to target
public class DirectionFinder : MonoBehaviour {
	// Assignable input values
	public KeyCode pitchUp 		= KeyCode.UpArrow;
	public KeyCode pitchDown 	= KeyCode.DownArrow;
	public KeyCode rotLeft 		= KeyCode.LeftArrow;
	public KeyCode rotRight 	= KeyCode.RightArrow;

	// Control values
	public float rotateSpeed = 20.0f; // degrees per second
	public Transform target;
	Vector3 dirToTarget;
	float distToTarget;
	float angToTarget;

	// GUI rectangles
	Rect guiArea = new Rect(10, 10, 200, 128);
	Rect guiBG	 = new Rect(0,  0,  200, 128);
	Rect guiDir  = new Rect(10, 10, 512, 20);
	Rect guiDis  = new Rect(10, 34, 512, 20);
	Rect guiAng  = new Rect(10, 58, 512, 20);

	// Update is called once per frame
	void Update () {
		// Update our input for rotation
		if (Input.GetKey (pitchUp))
			transform.Rotate (-rotateSpeed*Time.deltaTime, 0.0f, 0.0f);
		if (Input.GetKey (pitchDown))
			transform.Rotate (rotateSpeed*Time.deltaTime, 0.0f, 0.0f);

		if (Input.GetKey (rotLeft))
			transform.Rotate (0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
		if (Input.GetKey (rotRight))
			transform.Rotate (0.0f, rotateSpeed * Time.deltaTime, 0.0f);

		// Compute all the maths and such
		dirToTarget = target.position - transform.position;
		distToTarget = dirToTarget.magnitude;
		// use dot product to find the angle between forward and toTarget
		angToTarget = Vector3.Dot(transform.forward, dirToTarget.normalized);
		// dot = cosine of angle, inverse that using acos to get the angle
		angToTarget = Mathf.Acos (angToTarget);
		// the angle is now in radians, multiply by 180/pi to convert to degrees
		angToTarget = angToTarget * (180.0f / Mathf.PI);
	}

	void OnGUI() {
		// Set our coordinate group
		GUI.BeginGroup (guiArea);

		// draw stuff!
		GUI.Box (guiBG, GUIContent.none);
		GUI.Label (guiDir, "Direction: " + dirToTarget.normalized.x + ", " + dirToTarget.normalized.y + ", " + dirToTarget.normalized.z);
		GUI.Label (guiDis, "Distance: " + distToTarget + "m");
		GUI.Label (guiAng, "Angle: " + angToTarget);

		// MUST NOT FORGET
		GUI.EndGroup ();
	}
}





