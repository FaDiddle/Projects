using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishColl : MonoBehaviour {
	public GameObject DestroyText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void OnTriggerEnter (Collider col){
		if (col.gameObject.CompareTag ("Finish")) {
			Destroy (DestroyText);
			Destroy (gameObject);

		}

	}
}
