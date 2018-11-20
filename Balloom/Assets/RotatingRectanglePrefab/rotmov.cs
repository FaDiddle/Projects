
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotmov : MonoBehaviour {

	public float rota = 20f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0f,-5f,0f) * rota * Time.fixedDeltaTime);
	}
	 void OnTriggerEnter(Collider col)
	{


	}
}
