using UnityEngine;
using System.Collections;

public class HandRay : MonoBehaviour {
	
	public MouvementPerso mouvementPerso;
	public HandRay handRay;
	public CustomGUI customGUI;
	public Transform curseurRayon;
	public Texture2D LoadingGUI;
	public GUIStyle customButton;

	
	public float activeDistance = 10f;
	public bool showPicto = false;
	public bool loading = false;
	public static float loadingTime = 5f; // Temps du Loader
	public static bool isTimingforObjet = false; // Timer du loading des Objets : le décompte par défaut n'a pas encore commencé.
	public static float timerObjet = 0; // Loader de chaque GUI. Mémarre tout naturellement à zero.
	public string pictoMsg;
	
	void OnGUI () {


		//public static string textFieldString = HandRay.pictoMsg;

		
		if (loading) {
			GUI.Label (new Rect (Screen.width - 500, Screen.height - 250,100,100), LoadingGUI, customButton);
		}
		
		if (showPicto) {
			GUI.TextField (new Rect (Screen.width - 500, Screen.height - 250,100,90), pictoMsg);
		}
	}
	
	void Update () {
		
		// Timer du Loader
		
		if (isTimingforObjet) {
			
			timerObjet = timerObjet + Time.deltaTime;
			
		} else {
			
			timerObjet=0;
		}
		
		
		RaycastHit hit;
		
		// Définition de la longueur du rayonCurseur
		curseurRayon.localScale = new Vector3 (curseurRayon.localScale.x, activeDistance * 2, curseurRayon.localScale.z);
		
		// L'axe des Z mis dans la variable profondeur
		Vector3 profondeur = transform.forward;
		
		//Met à jour la position de curseurRayon à chaque frame
		curseurRayon.position = transform.position;
		
		curseurRayon.up = profondeur;
		
		if (Physics.Raycast (transform.position, profondeur, out hit,activeDistance)) {
			
			if ( Activable.isActivable(hit.transform.tag) && hit.collider.gameObject.CompareTag("Bouche_Aeration") ) {
				
				isTimingforObjet = true;
				
				if (timerObjet > loadingTime) {
					pictoMsg = Activable.picto;
					loading = false;
					showPicto = true;
				}  else {
					loading = true;
					showPicto = false;
					
				}
			}
				
				else {
					isTimingforObjet = false;
					loading = false;
					showPicto = false;	
				}
				
			}
		}
	}
