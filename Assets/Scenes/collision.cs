using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col) {

		print(gameObject.name);
		print ("hi");
		print (col.collider.gameObject.name);
	}
}
