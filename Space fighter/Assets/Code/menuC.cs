using UnityEngine;
using System.Collections;

public class menuC : MonoBehaviour {
	public GUISkin style;

	void OnGUI(){
		GUI.skin = style;
		GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 200f, 100f), "Asteroid Attack");

		if (GUI.Button (new Rect (Screen.width / 2 - 100f, Screen.height / 2 + 200f,200f,50f),"Start")) {
			Application.LoadLevel (1);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
