using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {

	public float turnSpeed = 20;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(0,0,20) * turnSpeed * Time.deltaTime);
	}
}
