using UnityEngine;
using System.Collections;

public class Activable2 : MonoBehaviour {
	
	public GUI GUI;

	public float loadingTime = 15f;
	public float startTime = 0;
	public string picto;
	public bool displayPicto = false;


	public void start () {

		startTime = Time.time;
	}

	public bool isTimeStarted() {
		return startTime > 0;
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
