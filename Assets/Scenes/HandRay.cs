using UnityEngine;
using System.Collections;

public class HandRay : MonoBehaviour {

	public MouvementPerso mouvementPerso;
	public CustomGUI customGUI;
	public GameObject touchable;
	public Transform curseurRayon;
	public Texture2D imgActivable;
	public Activable activable;

	public float activeDistance = 40f;
	public bool loaderStart = false;
	//private string texteFauneFloreMarine = "Lorem Ipsum sit dolor amet";
	
	void Start() {
		activable = new Activable();
	}

	void OnGUI () {

		if (loaderStart) {

			GUI.DrawTexture (new Rect (100, 100, 60, 60), imgActivable, ScaleMode.ScaleToFit, true, 10.0F);
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



				if (!activable.isTimeStarted()) {

					activable.start();
					print ("timer");
					activable.picto = "(n___n)";

				}

				if (activable.isReady()) {
					activable.showPicto();
					print ("affiche le picto !");
				}
			} else {
				activable.reset();
			}
		}
	}
}

