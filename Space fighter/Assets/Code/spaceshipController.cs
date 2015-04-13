using UnityEngine;
using System.Collections;

public class spaceshipController : MonoBehaviour
{

	//1. the mouse position in screen coordinates
	Vector3 mousePos;
	//2. the mouse position in world coordinates
	Vector3 mPos;

	//6. adding a reference to the laser prefab
	public GameObject laser;
		
	// variables for score and lives and declare the variable as static
	public static int score;
	public static int lives;

	//add variable for GUI Skin
	public GUISkin stylesheet;
	//reference for sound
	public AudioClip Laserpewpew;
	// Use this for initialization
	void Start ()
	{
		//set initial score and lives that were declared as variables
		lives = 5;
		score = 0;
	}
	//gui code
	void OnGUI ()
	{
		//to load stylesheet
		GUI.skin = stylesheet;
		string ScoreLabel = "Score:";
		string LivesLabel = "Lives:";
		//(posx,posy,width,height)
		GUI.Label (new Rect (10f, 10f, 150, 20), ScoreLabel + score);
		//created space by adding 15px of spaceing
		GUI.Label (new Rect (Screen.width - 80f, 10f, 150, 20), LivesLabel + lives);
	}

	
	// Update is called once per frame
	void Update ()
	{

		//3. this line of code gets the mouse position in pixels
		mousePos = Input.mousePosition;

		//4. this line of code translates from pixels to spaceship based coordinates
		mPos = Camera.main.ScreenToWorldPoint (mousePos);

		//5. this line of code sets the x and y position of the spaceship
		transform.position = new Vector3 (mPos.x, -4f, 4f);
				
			
		//7. this line of code will create the laser when LEFT mouse button pressed
		if (Input.GetMouseButtonDown (0)) {
			//set position because a prefab never has a position ie.the position of a prefab isn't taken into consideration and need to be set when instanced in the code
			Instantiate (laser, new Vector3 (transform.position.x, transform.position.y, 4.1f), Quaternion.Euler (new Vector3 (0, 0, 90))); 
			//8. optional 
			//Instantiate (laser, transform.position, transform.rotation);
			audio.PlayOneShot(Laserpewpew);
		}	
		//reset score
		if (lives == 0) {
			Application.LoadLevel (0);
			//reset score
			score = 0;
			lives = 5;
		}
		//go back to mennu if excape is pressed
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel (0);
		}
	}
	//code which is sensitive to a collision
	void OnTriggerEnter2D (Collider2D otherObject)
	{
		if (otherObject.tag == "asteroid") {
			//decrease score
			spaceshipController.lives--;
			//Destroy the asteroid
			Destroy (otherObject.gameObject);


		}
	}
}
