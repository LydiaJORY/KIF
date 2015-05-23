using UnityEngine;
using System.Collections;

public class Move_keyboard : MonoBehaviour {

	public float vitesse;
	public Vector3 avant, arriere, Monte, Descend;
	public KeyCode ToucheAvant, ToucheMonte, ToucheArriere, ToucheDescend, oh;
	public float Speedy = 10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		MouvementPerso.fonctionBidon ();


		if(Input.GetKey(ToucheAvant))
		{
			//rigidbody.MovePosition(transform.position + transform.forward * vitesse);
			//transform.Translate(avant);
			//rigidbody.AddForce(transform.forward * vitesse *1);
			rigidbody.AddForce(Vector3.right * vitesse);

				}

		if (Input.GetKey (ToucheArriere) || Input.GetKey(KeyCode.S)) {
			
			//transform.Translate(arriere);
			//rigidbody.AddForce(transform.forward * vitesse *-1);
			rigidbody.AddForce(-Vector3.right * vitesse);
		}

		if (Input.GetKey (ToucheMonte)) {
			
			transform.Translate(Monte);
		}

		if (Input.GetKey (ToucheDescend)) {
			
			transform.Translate(Descend);
		}


		if (Input.GetKey (KeyCode.LeftArrow)) {
			
			//rigidbody.AddForce(transform.right * vitesse * -1);
			rigidbody.AddForce(Vector3.forward * vitesse);
			//transform.Translate(Vector3.left * vitesse);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			//rigidbody.AddForce(transform.right * vitesse);
			rigidbody.AddForce(-Vector3.forward * vitesse);
			//transform.Translate(Vector3.right * vitesse);
		}



	
	}
}
