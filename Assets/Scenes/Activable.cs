using UnityEngine;
using System.Collections;
using System;

public class Activable : MonoBehaviour {

	// Toutes les methodes sont en statique pour nous permetre d'instancer de nouveaux objects (ce que MonoBehavour ne permet pas)
	public GUI GUI;
	public static float loadingTime = 5f; // Temps du Loader
	public static string picto;


	public static bool isReady () {
		return (Time.deltaTime + loadingTime) < Time.time;
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
