using UnityEngine;
using System.Collections;

public class MoveKeyboard : MonoBehaviour {

	public float vitesse;
	public Vector3 avant, arriere, sauter;
	public KeyCode toucheAvant, toucheSauter, toucheArriere;


	void Update () {

		// AVANCER
		if(Input.GetKey(toucheAvant)) {

			rigidbody.AddForce(Vector3.right * vitesse);
		}

		// RECULER
		if (Input.GetKey (toucheArriere) || Input.GetKey(KeyCode.S)) {
			
			rigidbody.AddForce(-Vector3.right * vitesse);
		}

		// SAUTER
		if (Input.GetKey (toucheSauter)) {
			
			transform.Translate(sauter);
		}

		// DROITE
		if (Input.GetKey (KeyCode.RightArrow)) {
			
			rigidbody.AddForce(-Vector3.forward * vitesse);
		}

		// GAUCHE
		if (Input.GetKey (KeyCode.LeftArrow)) {	

			rigidbody.AddForce(Vector3.forward * vitesse);
		}
	}
}
