using UnityEngine;
using System.Collections;

public class HandRay : MonoBehaviour {

	public MouvementPerso mouvementPerso;
	public CustomGUI customGUI;
	public GameObject touchable;
	public Transform curseurRayon;
	public Texture2D imgActivable;
	public static GameObject obj;

	public float activeDistance = 40f;
	public bool showPicto = false;
	public bool loading = false;

	void OnGUI () {
		if (loading) {
			GUI.Box (new Rect (10,10,100,90), "Loading...");
		}

		if (showPicto) {
			GUI.Box (new Rect (10,10,100,90), "Picto");
		}
	}

	void Update () {

		RaycastHit hit;

		// Définition de la longueur du rayonCurseur
		curseurRayon.localScale = new Vector3 (curseurRayon.localScale.x, activeDistance * 2, curseurRayon.localScale.z);

		// L'axe des Z mis dans la variable profondeur
		Vector3 profondeur = transform.forward;

		//Met à jour la position de curseurRayon à chaque frame
		curseurRayon.position = transform.position;

		curseurRayon.up = profondeur;
		
		if (Physics.Raycast (transform.position, profondeur, out hit,activeDistance)) {

			if (hit.transform.tag == "activable"){

				if (!Activable.isTimeStarted()) {
					Activable.start();
				}

				if (Activable.isReady()) {
					loading = false;
					showPicto = true;
				} else {
					loading = true;
					showPicto = false;
				}
			} else {
				loading = false;
				showPicto = false;
				Activable.reset ();
			}
		}
	}
}
