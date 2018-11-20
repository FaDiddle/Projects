using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonwithPlayer : MonoBehaviour {

	public GameObject button;
	public GameObject Finishline;
	// Update is called once per frame
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.CompareTag ("Player")) {
			Finishline.SetActive (true);
			button.SetActive (false);

		}
	}
}
