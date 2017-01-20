using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	
	void Start () {
		
	}

	void Update () {
		float horizontal = Input.GetAxisRaw ("Horizontal");
		transform.Rotate (new Vector3 (0, 0, horizontal));
	}
}
