
using UnityEngine;
using System.Collections;

public class MouvementPerso : MonoBehaviour {
	
	// Déclaration des variables
	public Transform corps, maCamera;
	public Transform epGauche,epDroite,mainGauche,mainDroite,ventre;

	public float vitesseAvant = 10f;
	private float vitesseTourne = 5f;
	public float ecartementAvant = 10f;
	public float ecartementTourne,ecartementMain = 0.2f;
	

	void Update () {


		float corpsPosition = corps.localPosition.z;  // *10 CAR MA KInect n'est pas assez sensible
		float epauleDroite = epDroite.localPosition.z;
		print ("La position du corps est " + corpsPosition);
		print ("La position de l'épaule droite est " + epauleDroite);

		// Avancer
		if (corpsPosition > ecartementAvant) {
			print (" Je suis en train d'avance");
			rigidbody.AddForce(Vector3.right * vitesseAvant);	

		}

		// Reculer
		if (corpsPosition < -ecartementAvant) {
			print (" Je suis en train de reculer");
			rigidbody.AddForce(Vector3.right * -vitesseAvant);	
		}

		// Tourner Gauche
		if (epauleDroite > (epGauche.localPosition.z + ecartementTourne)) {
			print("Je suis en train de tourner a gauche");
			corps.Rotate (new Vector3 ( 0,vitesseTourne,0));

		
		}
		// Tourner Droite
		if (epauleDroite < (epGauche.localPosition.z - ecartementTourne)) {
			print("Je suis en train de tourner a droite");
			corps.Rotate (new Vector3 ( 0,-vitesseTourne,0));	
		}
	}
}
