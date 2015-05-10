/*using UnityEngine;
using System.Collections;

public class Ray : MonoBehaviour {

	//public GameObject mainDroite;
	public float activeDistance = 40;
	public Camera cam;
	public Vector3 positionMain;
	public Transform rayon;
	public Transform mainDroite, epaules;
	public GameObject touchable;
	public Transform cylindre;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		cylindre.localScale = new Vector3 (cylindre.localScale.x, activeDistance * 2, cylindre.localScale.z);
		Vector3 forward = transform.forward; // new Vector3 (0,0,-1);//transform.TransformDirection(Vector3.forward) * 10;
		//Debug.DrawRay(transform.position, forward, Color.green);
		rayon.position = transform.position;
		rayon.up = forward;
		if (Physics.Raycast (transform.position, forward, out hit,activeDistance)) {
			//print (hit.collider.name);
			//print(hit.collider.tag);
			//print (hit.distance);
			if((hit.collider.tag == "activable")){

				print ("ACTIVER!!!");

			}
				

		}
	
	}

	void OnCollisionEnter (Collision col){

		}
}*/





using UnityEngine;
using System.Collections;

public class Ray : MonoBehaviour {
	
	//public GameObject mainDroite;
	public float activeDistance =40;
	public Camera cam;
	public Vector3 positionMain;
	public Transform rayon;
	public Transform mainDroite, epDroite;
	public GameObject touchable;
	public Transform cylindre;
	
	// Variable pour le picto qui montre qu'un objet est activable
	// Il faut insérer l'image en public
	public Texture2D imgActivable;
	
	// On peut régler la typo des textes en public dans Unity
	public GUIStyle customButton;
	
	// Texte pour le GUI
	private string texteFauneFloreMarine = "Blablabla\nBlablabla";
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		cylindre.localScale = new Vector3 (cylindre.localScale.x, activeDistance * 2, cylindre.localScale.z);
		Vector3 forward = transform.forward; // new Vector3 (0,0,-1);//transform.TransformDirection(Vector3.forward) * 10;
		Debug.DrawRay(transform.position, forward, Color.green);
		rayon.position = transform.position;
		rayon.up = forward;
		
		if (Physics.Raycast (transform.position, forward, out hit,activeDistance)) {
			//print (hit.collider.name);
			//print(hit.collider.tag);
			//print (hit.distance);
			
			// Si le rayon touche un objet taggé "objetActivable"
			if((hit.collider.tag == "objetActivable")){
				
				// On affiche une image pour faire comprendre au joueur qu'il peut intéragir avec
				//print ("Affiche le picto");
				GUI.DrawTexture(new Rect(10, 10, 60, 60), imgActivable, ScaleMode.ScaleToFit, true, 10.0F);
				
				// Si la main droite est au dessus de l'épaule droite (et si compte à rebours)
				if (mainDroite.localPosition.y > epDroite.localPosition.y)  {
					//print("Active l'objet");
					
					// Si l'objet est une porte
					if((hit.collider.tag == "activePorte")){
					}
					
					// Si l'objet est une lampe
					if((hit.collider.tag == "activeLampe")){
					}
					
					// Si l'objet affiche un GUI
					if((hit.collider.tag == "activeGUI")){
						
						// Si l'objet est un hublo
						if((hit.collider.tag == "guiFauneFloreMarine")){
							// Une GUI qui récupère le texte de la variable
							GUI.Box (new Rect(Screen.width / 2 - 500 / 2, Screen.height / 2 - 240, 500, 200), texteFauneFloreMarine, customButton);
						}
					}					
				}
			}			
		}
	}
	
	void OnCollisionEnter (Collision col){
		
	}
}

