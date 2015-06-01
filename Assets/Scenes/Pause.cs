using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public MouvementPerso MouvementPerso;
	public CustomGUI customGUI;
	public GUI GUI;
	public float ecartementMain;
	public float tempsPause = 0;
	public bool pauseEnAttente = false;
	private bool enPause = false;
	
	public void Start () {
		tempsPause = Time.time;
	}
	

	void Update () {

		if (Time.time-tempsPause >2 && (isMainsMemeHauteur() || Input.GetKey(KeyCode.Escape)) ) {
			enPause = true;
			print ("ca serait cool de passer en pause...");
		}
	}

	public bool isMainsMemeHauteur() {
		
		float mainDroitePosition = MouvementPerso.mainDroite.localPosition.y;
		float mainGauchePosition = MouvementPerso.mainGauche.localPosition.y;
		float mainDroiteEcartMin = mainDroitePosition - ecartementMain;
		float mainDroiteEcartMax = mainDroitePosition + ecartementMain;
		
		return (
			   (mainGauchePosition <= mainDroiteEcartMax) 
			&& (mainGauchePosition >= mainDroiteEcartMin) 
			&& (MouvementPerso.mainGauche.localPosition.z> MouvementPerso.corps.localPosition.z+ecartementMain)
			&& (MouvementPerso.mainDroite.localPosition.z> MouvementPerso.corps.localPosition.z+ecartementMain)
			&& (MouvementPerso.mainDroite.localPosition.y > MouvementPerso.ventre.localPosition.y)
		);
	}

	public void OnGUI () {

		// Si le jeu est en pause, on affiche
		if (enPause) {
			GUI.Box (new Rect (10, 10, 100, 90), "PAUUUUUSE");
			GUI.Box (new Rect (Screen.width / 2 - 100 / 2, Screen.height / 2 - 200, 100, 40), "Pause", customGUI.customButton);
			print ("PAUSE");

			if (!isMainsMemeHauteur ()) {
				pauseEnAttente = true;
			
			} else if (pauseEnAttente) {
				pauseEnAttente = false;
				enPause = false;
				tempsPause = Time.time;
			}
		}
	}
}
