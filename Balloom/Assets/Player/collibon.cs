using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collibon : MonoBehaviour {

	public int falling = -5;
	void Update(){
		if (transform.position.y <= falling)
		{
			Destroy (gameObject);
		}
			
		}




	private void OnTriggerEnter (Collider col){
		if (col.gameObject.CompareTag ("Enemy")) {
			Destroy (gameObject);
		}

	}

}
