using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {

	void onCollisionEnter2D(Collision2D c){

		if (c.gameObject.tag == "Piso") {
			Destroy (c.gameObject);
		}

	}

	void onCollisionStay2D(Collision2D c){
	}

	void onColisionExit2D(Collision2D c){
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
