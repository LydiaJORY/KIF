using UnityEngine;
using System.Collections;
using System;

public class Activable : MonoBehaviour {

	public static GUI GUI;


	public static float loadingTime = 5;
	public static float startTime = 0;
	public static string picto;

	public static void start () {

		startTime = Time.time;
	}

	public static bool isTimeStarted() {
		return startTime > 0;
	}
	
	public static bool isReady () {
		return (startTime + loadingTime) < Time.time;
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
}
