using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour {

	public BasicCard[] cards;
	public PlayerController[] players;

	// Use this for initialization
	void OnEnable () {
		cards = FindObjectsOfType<BasicCard> ();
		players = FindObjectsOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		//checkCards(); This isn't done yet
	}
	//check cards array; if all cards have targets, move to showing card assignments and apply affects.
	void checkCards(){
		bool cardsReady = true;
		for (int i = 0; i <= cards.Length; i++) {
			if (cards [i].target == null) cardsReady = false;
		}
		if (cardsReady) {
			for (int i = 0; i <= cards.Length; i++) {
				//Play whatever animation we have for applying affects, then...
				//cards[i].EnactEffect();
			}
		}
	}
}
