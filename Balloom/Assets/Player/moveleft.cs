using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class moveleft : MonoBehaviour {
	public float speed = 5f;
	bool left = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame




	public void PointerDown ()
	{
		left = true;
	}


	void FixedUpdate()
	{
		if (left == true)
		{
			transform.Translate (Vector3.left * speed * Time.fixedDeltaTime);
		}

	}
		
		

	public void PointerUp ()
			{

		left = false;
	
	}



}

	

