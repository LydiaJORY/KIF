using UnityEngine;
using System.Collections;

public class MouvementPerso : MonoBehaviour {
	
	// Déclaration des variables
	public Transform corps, centreSalle, maCamera;
	public Transform epGauche,epDroite,mainGauche,mainDroite,ventre;

	public float vitesseAvant = 10f;
	public float vitesseTourne = 0.05f;
	public float ecartementAvant = 0.4f;
	public float ecartementTourne,ecartementMain = 0.2f;
	

	void Update () {



		float corpsPosition = corps.localPosition.z;  // *10 CAR MA KInect n'est pas assez sensible
		float epauleDroite = epDroite.localPosition.z;

		// Avancer
		if (corpsPosition > ecartementAvant) {

				print ("avance");
				centreSalle.Translate (new Vector3 (0, 0, vitesseAvant));	
			}
		// Reculer
		if (corpsPosition < -ecartementAvant) {
			//	print ("recule");
			centreSalle.Translate (new Vector3 (0, 0, -vitesseAvant));
		}

		// Tourner Gauche
		if (epauleDroite > (epGauche.localPosition.z + ecartementTourne)) {
			//	print("premier");
			centreSalle.Rotate (new Vector3 (0, -vitesseTourne, 0));
		}
		// Tourner Droite
		if (epauleDroite < (epGauche.localPosition.z - ecartementTourne)) {
			print("deuxième");
			centreSalle.Rotate (new Vector3 (0, vitesseTourne, 0));		
		}
	}
}
