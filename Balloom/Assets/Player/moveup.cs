using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveup : MonoBehaviour {
	public float speed = 5f;
	bool jump = false;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame




	public void PointerDown () //turns on button command to repeat 
	{
		jump = true;
	}


	void FixedUpdate()
	{
		if (jump == true)
		{
			rb.velocity = new Vector3 (0, 10f, 0) * speed * Time.fixedDeltaTime;
		}

	}



	public void PointerUp ()  //turns off button
	{

		jump = false;

	}

}
