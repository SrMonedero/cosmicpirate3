using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private bool jumping = false;
	private float jumpEnergy = 300;
	private float jumpEnergyLoss = 100;

	void Update () {
		float horizontal = Input.GetAxisRaw ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		if (horizontal != 0) {
			if (horizontal > 0) {
				transform.eulerAngles = new Vector3 (0, 180f, 0);
			} else {
				transform.eulerAngles = Vector3.zero;
			}
		}
		if (jumpEnergy > 0 && vertical > 0) {
			jumping = true;
			Rigidbody2D body = GetComponent<Rigidbody2D> ();
			jumpEnergy -= jumpEnergyLoss;
			body.AddForce (new Vector2 (0, jumpEnergyLoss));
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		jumping = false;
		jumpEnergy = 200;
		Debug.Log ("collision");
	}
}
