using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {
	void Update () {
		float horizontal = Input.GetAxisRaw ("Horizontal");
		if (horizontal != 0) {
			if (horizontal > 0) {
				transform.eulerAngles = new Vector3 (0, 180f, 0);
			} else {
				transform.eulerAngles = Vector3.zero;
			}
		}
	}
}
