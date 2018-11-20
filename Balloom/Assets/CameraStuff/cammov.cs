using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammov : MonoBehaviour {
	public float cameraspeed = 5;
	public GameObject cube;
	// Update is called once per frame
	void FixedUpdate () {
		if (cube != true) {
			transform.Translate (new Vector3 (0, 0, 0) * Time.fixedDeltaTime);
		} else {
			transform.Translate(Vector3.forward * cameraspeed * Time.fixedDeltaTime);
		}
	}
}
