using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour {
	
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Loader Menu");
		

		if(GUI.Button(new Rect(20,40,80,20), "Level_One")) {
			Application.LoadLevel("Level_One");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
			Application.LoadLevel("Prison");
		}
	}
}
