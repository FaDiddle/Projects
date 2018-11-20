using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	private static int score;
	public Text Displayer;
	public GameObject Player;

	// Use this for initialization

	void FixedUpdate(){
		score = ScoreNow.TimeStart;
	}
	// Update is called once per frame
	void Update () {
		Displayer.text = ("Points: " + score);
	

		//Counter
		if (Player != true) {

			Displayer.text = ("Results:" + score + " Press Space to Restrat");

			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex ) ;
													}
							}
	
					}


		

}

