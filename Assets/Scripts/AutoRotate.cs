using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour {
	public float speed = 0.01f;
	public float distanceFactorSpeed = 1f;

	void Start () {
		
	}

	void Update () {
		float horizontal = Input.GetAxisRaw ("Horizontal");
		transform.Rotate (0,0,horizontal * distanceFactorSpeed + speed * Time.deltaTime);	
	}
}
