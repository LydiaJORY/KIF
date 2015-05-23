using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	float tempsPause = 0;
	bool pauseEnAttente = false;
	private bool enPause = false;
	public mouvementPerso MouvementPerso;

	// Use this for initialization
	void Start () {

		tempsPause = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( isMainsMemeHauteur() || Input.GetKey(KeyCode.Escape) ) {
			//enPause = !enPause;
			if(Time.time-tempsPause >2){
				enPause = true;
				print ("ca serait cool de passer en pause...");
				,
		}

		public bool isMainsMemeHauteur() {
			float mainDroitePosition = mainDroite.localPosition.y;
			float mainGauchePosition = mainGauche.localPosition.y;
			float mainDroiteEcartMin = mainDroitePosition - ecartementMain;
			float mainDroiteEcartMax = mainDroitePosition + ecartementMain;
			
			// Si main Gauche est comprise dans dans l'écart min/max de la main droite 
			print ((mainGauchePosition <= mainDroiteEcartMax).ToString () 
			       +" "+ (mainGauchePosition >= mainDroiteEcartMin).ToString ()
			       +" "+ (mainGauche.localPosition.z> corps.localPosition.z+ecartementMain)
			       +" "+ (mainDroite.localPosition.z> corps.localPosition.z+ecartementMain)
			       +" "+ (mainDroite.localPosition.y > ventre.localPosition.y));
			
			return ((mainGauchePosition <= mainDroiteEcartMax) 
			        && (mainGauchePosition >= mainDroiteEcartMin) 
			        && (mainGauche.localPosition.z> corps.localPosition.z+ecartementMain)
			        && (mainDroite.localPosition.z> corps.localPosition.z+ecartementMain)
			        && (mainDroite.localPosition.y > ventre.localPosition.y));
		}
		

	
	}

	void OnGUI () {
		
		// Si le jeu est en pause, on affiche
		
		
		if (enPause) {
			GUI.Box(new Rect(10,10,100,90), "PAUUUUUSE");
			GUI.Box(new Rect(Screen.width / 2 - 100 / 2, Screen.height / 2 - 200, 100, 40), "Pause", customButton);
			print ("PAUSE");
			if(!isMainsMemeHauteur()){
				pauseEnAttente=true;
			}
			else if(pauseEnAttente){
				pauseEnAttente=false;
				enPause = false;
				tempsPause = Time.time;
			}
		}
}
