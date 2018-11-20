using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class ScoreNow : MonoBehaviour {
	public static int TimeStart= 0;

	public GameObject Player;

	// Use this for initialization
	void Start () {
		StartCoroutine ("AddTime");

		Time.timeScale = 1; //just makes sure the time scale is right 
	}

	// Update is called once per frame
	void Update () {






		//Counter
		if (Player != true) {
			StopCoroutine ("AddTime");
		

			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex ) ;
				TimeStart = 0;
			}

		}

	}


	IEnumerator AddTime(){
		while (true) {
			yield return new WaitForSeconds (1);
			TimeStart++;

		}
	}
}