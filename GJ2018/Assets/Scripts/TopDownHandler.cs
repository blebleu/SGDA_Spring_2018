using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownHandler : MonoBehaviour {

	public PlayerController myPlayer; //The player controlling this game object.
									  //Currently must be set in inspector, but will fix that.
	Rigidbody2D myRB;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		getInput ();
	}

	void getInput(){
		//A Button
		if (myPlayer.InputButtonA()) {
			Debug.Log ("A Button on controller " + myPlayer.controller + " Pressed.");
		}
		if (myPlayer.InputButtonB()) {
			Debug.Log ("B Button on controller " + myPlayer.controller + " Pressed.");
		}
		Debug.Log ("Left Joystick on controller " + myPlayer.controller + " Pressed: " + myPlayer.InputJoyStick());
		myRB.AddForce (myPlayer.InputJoyStick() * myPlayer.speed);
	}
}
