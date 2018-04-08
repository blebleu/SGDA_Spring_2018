using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public int controller = 1; //Which controller is the player using? 1-4
	public float speed = 1; //Player speed. Multiplier; 1 = normal, 0.5 = half speed, etc.
	public float size = 1; //Player size/scale. Multiplier
	public float density = 1; //Player weight/mass. Multiplier
	public float cool = 0; //Player coolness. Not a multiplier.

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Vector2 InputJoyStick(){
		//Left Joystick
		//Calculate X axis
		float xInput = 0.0f;
		xInput += Input.GetAxis ("Joy" + controller + "X");

		//Calculate Y axis
		float yInput = 0.0f;
		yInput += Input.GetAxis ("Joy" + controller + "Y");

		return new Vector2 (xInput, yInput);

	}
	public bool InputButtonA(){
		//Button A
		return Input.GetButtonDown ("Joy" + controller + "A");
	}
	public bool InputButtonB(){
		//Button B
		return Input.GetButtonDown ("Joy" + controller + "B");
	}
}
