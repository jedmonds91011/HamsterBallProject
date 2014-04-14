using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {
	public Transform[] patrolPoints;
	public float moveSpeed; 
	public int totalPoints;
	private float currentRotation;

	private int currentPoint;
	// Use this for initialization
	void Start () {
		transform.position = patrolPoints [0].position;
		currentRotation = gameObject.transform.rotation.y;
		currentPoint = 0;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position == patrolPoints[currentPoint].position)
		{
			currentPoint++;
			currentPoint %= totalPoints;

		}
		transform.position = Vector3.MoveTowards (transform.position, patrolPoints [currentPoint].position, moveSpeed * Time.deltaTime );

	}
}
