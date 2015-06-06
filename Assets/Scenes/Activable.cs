using UnityEngine;
using System.Collections;
using System;

public class Activable : MonoBehaviour {

	// Toutes les methodes sont en statique pour nous permetre d'instancer de nouveaux objects (ce que MonoBehavour ne permet pas)
	public GUI GUI;
	public static float loadingTime = 5; // Temps du Loader
	public static float startTime = 0; // Temps écoulé depuis le jeu lancé
	public static string picto;


	public static void start () {

		startTime = Time.time;

	}

	public static bool isTimeStarted() {
		return startTime > 0;

	}
	
	public static bool isReady () {
		return (Time.deltaTime + loadingTime) < Time.time;
	}
	
	public static void reset() {
		startTime = 0;

	}

	public static bool isActivable (string tag) {

		switch (tag) {

			case "Hublot":
				picto="Hublot picto";
				break;
			
			case "Bouche_Aeration" :
				picto="BoucheAeration";
				break;
		}

		return picto != null;
	}

	void Update (){


	}
}
