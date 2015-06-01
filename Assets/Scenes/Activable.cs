using UnityEngine;
using System.Collections;

public class Activable : MonoBehaviour {

	public float loadingTime = 15f;
	public float startTime = 0;
	public string picto;
	public GUI GUI;
	public bool displayPicto = false;

	public bool isTimeStarted() {
		return startTime > 0;
	}
	
	public void start () {
		print ("onGUI");
		startTime = Time.time;
	}

	public bool isReady () {
		return (startTime + loadingTime) > Time.time;
	}

	public void showPicto() {

		displayPicto = true;


	}

	public void reset() {
		startTime = 0;
		displayPicto = false;
	}

	// Afficher pictograme
	void onGUI () {

		print ("onGUI");


		if (displayPicto) {
			print ("diplay picto");
			GUI.Box (new Rect (10, 10, 100, 90), "LOADER");

		}
	}


}
