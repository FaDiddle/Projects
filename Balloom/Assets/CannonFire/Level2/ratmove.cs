﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratmove : MonoBehaviour {
	public float speed = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3 (0,0,1) * speed * Time.fixedDeltaTime);
	}
}
