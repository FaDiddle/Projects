using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveright : MonoBehaviour {
	public float speed = 5f;
	bool right = false;

	public void PointerDown ()
	{
		right = true;
	}


	void FixedUpdate()
	{
		if (right == true)
		{
			transform.Translate (Vector3.right * speed * Time.fixedDeltaTime);
		}

	}



	public void PointerUp ()
	{

		right = false;

	}



}


