using UnityEngine;
using System.Collections;

public class CustomGUI : MonoBehaviour {

	public MouvementPerso mouvementPerso;
	public GUIStyle customButton;
	public GUI GUI;

	// Update is called once per frame
	void OnGUI () {

		if (Input.GetKey (KeyCode.A)){

			print ("l");
			GUI.Box(new Rect(10,10,100,90), "Loader Menu");
		}	
	}
}
