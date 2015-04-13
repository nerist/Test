using UnityEngine;
using System.Collections;

public class asteroidCreator : MonoBehaviour
{
	//Create variable for the asteroid game object
	public GameObject asteroid;
	//declare variable for the asteroid x position (which will be random)
	float asteroidPosition;
	// declare a coroutine which will run all the time during the update
	IEnumerator createAsteroid ()
	{
		while (true) {
			//set random number for x spawn position
			asteroidPosition = Random.Range (-6f, 6f);
			//will work forever every 3 seconds
			yield return new WaitForSeconds (1.5f);
			//Spawn asteroid
			Instantiate (asteroid, new Vector3 (asteroidPosition, 5, 4), Quaternion.identity);

		}

	}
	// Use this for initialization
	void Start ()
	{
		//start corutine user defined function createAsteroid
		StartCoroutine ("createAsteroid");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
