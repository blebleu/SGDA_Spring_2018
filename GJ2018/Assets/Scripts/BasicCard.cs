using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicCard : MonoBehaviour {

	public enum Stats {Speed,Size,Density,Cool};
	public Stats affectedStat; //The stat the card will change
	public string cardName; //What the name of the card is; flavor.
	public string cardEffect; //Readout of the card's effects
	public PlayerController target; //Who the card will affect.
	public bool selected; //Is this card selected by its owner on the menu?
	public PlayerController owner; //The player who controls this card.
	public float strength; //How much to change the affectedStat
	menuManager manager;

	public Text NameText; //Holds the reference to the name textbox
	public Text EffectText; //Holds the reference to the effect textbox
	// Use this for initialization
	void Start(){
		
	}
	void OnEnable () {
		manager = FindObjectOfType<menuManager> ();
		if(strength>0)	cardEffect = affectedStat.ToString () + " +" + strength.ToString ();
		else cardEffect = affectedStat.ToString () + " " + strength.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		UIUpdate ();
	}
	//Apply the card's effect
	public void EnactEffect(){
		switch (affectedStat) {
			case Stats.Speed:
				target.speed += strength;
			break;
			case Stats.Size:
				target.size += strength;
			break;
			case Stats.Density:
				target.density += strength;
			break;
			case Stats.Cool:
				target.cool += strength;
			break;
		}
	}
	//Update the textboxes to match card info
	void UIUpdate(){
		//Check name
		if (NameText.text != cardName) NameText.text = cardName;
		//check effect
		if (EffectText.text != cardEffect) EffectText.text = cardEffect;
	}
	//check for input from owner
	void OwnerInput(){
		if (selected) {
			if (owner.InputButtonA()) {
				//check menuManager object for assignments, set target to match as long as it isnt the owner
				if (manager.players.Length >= 0) {
					if (manager.players [0] != owner) {
						target = manager.players [0];
					}
					else {
						//play a "nope" beep
					}
				}
				else {
					//play a "nope" beep
				}
			}
			if (owner.InputButtonB()) {
				//check menuManager object for assignments, set target to match as long as it isnt the owner
				if (manager.players.Length >= 1) {
					if (manager.players [1] != owner) {
						target = manager.players [1];
					}
					else {
						//play a "nope" beep
					}
				}
				else {
					//play a "nope" beep
				}
			}
			if (owner.InputButtonX()) {
				//check menuManager object for assignments, set target to match as long as it isnt the owner
				if (manager.players.Length >= 2) {
					if (manager.players [2] != owner) {
						target = manager.players [2];
					}
					else {
						//play a "nope" beep
					}
				}
				else {
					//play a "nope" beep
				}
			}
			if (owner.InputButtonY()) {
				//check menuManager object for assignments, set target to match as long as it isnt the owner
				if (manager.players.Length >= 3) {
					if (manager.players [3] != owner) {
						target = manager.players [3];
					}
					else {
						//play a "nope" beep
					}
				}
				else {
					//play a "nope" beep
				}
			}
		}
	}
}
