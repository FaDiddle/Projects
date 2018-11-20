using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed = 1;
	public float jumping = 5;
	public Rigidbody rb;
	public float forwarding = 5;
	public Joystick joystick;
	 

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate (Vector3.forward * forwarding * Time.fixedDeltaTime);


		if (Input.GetKey(KeyCode.LeftArrow)){
			 transform.Translate (Vector3.left * speed * Time.fixedDeltaTime);

	}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rb.velocity = new Vector3 (0, 10f, 0) * jumping * Time.fixedDeltaTime;
		
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Translate (Vector3.right * speed * Time.fixedDeltaTime);

		}

}
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

    }
}
