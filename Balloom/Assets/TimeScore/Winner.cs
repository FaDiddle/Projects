using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour {
	private static int win;
	public Text DisplayMessage;
	public GameObject scorecounter;
	// Update is called once per frame
	void Update () {
		win = ScoreNow.TimeStart;
		if (scorecounter != true) {
		
			DisplayMessage.text = ("You Win!  " + win);
		
		}



	}
}
