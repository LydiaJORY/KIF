﻿using UnityEngine;
using System.Collections;

public class GUI_KIF : MonoBehaviour {

	public mouvementPerso mouvementPerso;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {


		if (Input.GetKey (KeyCode.A)){

			print ("l");
			GUI.Box(new Rect(10,10,100,90), "Loader Menu");
		}

	
	}
	
}
