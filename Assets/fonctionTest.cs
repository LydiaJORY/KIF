using UnityEngine;
using System.Collections;

public class fonctionTest : MonoBehaviour {
	public mouvementPerso test1;
	// Use this for initialization
	void Start () {
		test1.isMainsMemeHauteur (); // parce que ce n'est pas une fonction static
		mouvementPerso.fonctionBidon (); // parce que c'est une fonction static
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
