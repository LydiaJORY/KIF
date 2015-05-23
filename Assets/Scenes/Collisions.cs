using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	public MouvementPerso mouvementPerso;

	// Use this for initialization
	void Start () {
		//test
	}
	
	// Update is called once per frame
	void Update () {



	}

	void OnCollisionEnter(Collision col) {

		print ("Tu es rentré en collision avec" + col.collider.gameObject.name);
	}
}
