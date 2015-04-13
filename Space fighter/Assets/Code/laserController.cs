using UnityEngine;
using System.Collections;

public class laserController : MonoBehaviour
{
		//controls the speed of the laser
		public int laserSpeed;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				//move in the local X-axis if ROTATED
				transform.Translate (new Vector3 (1, 0, 0) * laserSpeed * Time.deltaTime); 
				//if not rotated
				//transform.Translate (new Vector3 (0, 1, 0) * laserSpeed * Time.deltaTime); 
				//output the y coordinate of the laser
				Debug.Log (transform.position.y);

				if (transform.position.y > 5) {
						//delete the current laser
						Destroy (this.gameObject);
				}
		}

		//code which is sensitive to a collision
		void OnTriggerEnter2D (Collider2D otherObject)
		{
				if (otherObject.tag == "asteroid") {
						//increase score
						spaceshipController.score++;
						//Destroy the asteroid
						Destroy (otherObject.gameObject);
						//Destroy the laser
						Destroy (this.gameObject);
				}
		}

}
