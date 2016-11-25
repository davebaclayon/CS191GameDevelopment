using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour {

	public float moveRate = 0.07f;

	// Use this for initialization
	// This is called once it is called and load the script.
	// If you want to reset values, edit Start
	void Start () {
	    	
	}






	// Update is called once per frame
	// This is being called frame by frame
	// Start -> Update -> End Game
	void FixedUpdate () {
		// object will accept 2 things, x and y where y is constant since x is the only one changing.
		// y is not changing here
		// x is moving from right to left
		transform.position = new Vector2 (transform.position.x - moveRate,transform.position.y); 

		if (transform.position.x <= -27.51f) {
			//create a new position for this background
			//ibalik nimo sha sa start
			transform.position = new Vector2(27.51f,transform.position.y);
		}
	}
}
