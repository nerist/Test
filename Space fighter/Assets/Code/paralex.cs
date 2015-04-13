using UnityEngine;
using System.Collections;

public class paralex : MonoBehaviour {
	public float bgSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 1, 0) * bgSpeed * Time.deltaTime); 
	}
}
