using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public float speed = 1;

	void Start () {
		
	}

	void Update () {
		float horizontal = Input.GetAxisRaw ("Horizontal");
		transform.Rotate (new Vector3 (0, 0, horizontal * speed));
	}
}
