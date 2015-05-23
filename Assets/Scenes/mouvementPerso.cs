using UnityEngine;
using System.Collections;

public class MouvementPerso : MonoBehaviour {
	
	// Déclaration des variables
	
	public float vitesseAvant = 0.05f;
	public float vitesseTourne = 0.05f;
	public Transform corps,centreSalle,Macamera;
	public float ecartementAvant = 0.4f;
	public float ecartementTourne,ecartementMain = 0.2f;
	public Transform epGauche,epDroite,mainGauche,mainDroite,ventre;

	// On peut régler la typo des textes en public dans Unity
	public GUIStyle customButton;



	public static int multiplication(int nombreUn, int nombreDeux)
	{
		return nombreUn * nombreDeux;
	}


	

	
	
	// Use this for initialization
	void Start () {
		
		
	}

	public static void fonctionBidon(){
		print (" je suis dans la fonction bidon");
		}
	
	// Update is called once per frame
	void Update () {

		// avancer
		if (corps.localPosition.z > ecartementAvant) {
				//	print ("avance");
				centreSalle.Translate (new Vector3 (0, 0, vitesseAvant));	
			}
		// Reculer
		if (corps.localPosition.z < -ecartementAvant) {
			//	print ("recule");
			centreSalle.Translate (new Vector3 (0, 0, -vitesseAvant));
		}
		// Tourner Gauche
		
		if (epDroite.localPosition.z > (epGauche.localPosition.z + ecartementTourne)) {
			//	print("premier");
			centreSalle.Rotate (new Vector3 (0, -vitesseTourne, 0));
		}
		// Tourner Droite
		if (epDroite.localPosition.z < (epGauche.localPosition.z - ecartementTourne)) {
			//	print("deuxième");
			centreSalle.Rotate (new Vector3 (0, vitesseTourne, 0));
			
		}
	


	





		//	Time.timeScale = enPause ? 0 : 1;
	/*
		// On arrete le temps
		if (enPause) {
			Time.timeScale = 0f;
		}
		
		// Le temps reprend
		else {
			Time.timeScale = 1.0f;
		}

	*/	
		
		// Avancer
		//print (corps.localPosition.z);

		// Mettre en PAUSE

	// Afficher une interface

			  			
			/*centreSalle.Translate(new Vector3 (0,0,0));
			centreSalle.Translate(new Vector3 (0,0,0));
			centreSalle.Rotate(new Vector3 (0,0,0));
			centreSalle.Rotate(new Vector3 (0,0,0));
			
			// GUI MENU PAUSE
			// On affiche la box "Pause" centré sur la page et dans sa box
			GUI.Box(new Rect(Screen.width / 2 - 100 / 2, Screen.height / 2 - 200, 100, 40), "Pause", customButton);
			
			// Si les deux mains sont quasiment au meme niveau, alors on met le jeu en pause
			if ( (mainDroite.localPosition.y + ecartementMain) == (mainDroite.localPosition.y + ecartementMain) ) {

				// On retourne la variable enPause en faux
				//enPause = false;


			}
		}*/
	}

}
