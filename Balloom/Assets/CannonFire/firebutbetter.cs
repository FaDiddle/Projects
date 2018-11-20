using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebutbetter : MonoBehaviour {
	public float time = 3;
	public Rigidbody Sphere;
	public Transform fire;
	public float veloc = 30;
	/// <summary>Our current timer, counting down.</summary>
	public float countdownTimer = 3; 

	void Update()
	{
		countdownTimer -= Time.deltaTime;   // Reduce our countdown by the
		// it has been since our last update

		if(countdownTimer <= 0)        // IF our countdown timer is below
			// 0, we have reached 3 seconds.
		{
			countdownTimer = time;              // Reset our countdown,

			Rigidbody launchpower;
			launchpower = Instantiate (Sphere, fire.position, fire.rotation);
			launchpower.AddForce (fire.right * veloc);
		}
	}
}
