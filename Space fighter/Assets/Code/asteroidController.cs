using UnityEngine;
using System.Collections;

public class asteroidController : MonoBehaviour
{
	//this variable controls the speed of 
	//the asteroid's rotation
	public int asteroidSpeed;


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//runs all the time during the game

	
		//rotate in Z multiplied by speed multiplied
		//by how long it takes to draw a frame
		transform.Rotate (new Vector3 (0, 0, 1) * asteroidSpeed * Time.deltaTime);

		//move the asteroid DOWN towards the player in GLOBAL coordinates.  Asteroid stops at the bottom of the screen
		if (transform.position.y > -5.5f) {
			transform.Translate (new Vector3 (0, -1, 0) * asteroidSpeed * Time.deltaTime, Space.World);
		} else {
			//these will only happen if asteroid has hit the bottom
			Destroy(this.gameObject);
			spaceshipController.lives--;

		}
	}
}
