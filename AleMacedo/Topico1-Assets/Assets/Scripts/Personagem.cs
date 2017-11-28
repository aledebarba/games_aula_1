using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour {

	public float velocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float move_x = Input.GetAxis ("Horizontal") * velocidade * Time.deltaTime;
		float move_y = Input.GetAxis ("Vertical") * velocidade * Time.deltaTime;

		transform.Translate (move_x, move_y, 0.0f);
		if (Input.GetButtonDown ("Jump")) {
			transform.position = Vector2.zero;
		}
	}
}
