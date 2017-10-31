using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
	int rotationSpeed =1000;
	int jumpHeight = 8;
	public Rigidbody rb;
	private bool isFalling = false;


	void Start () {
		print ("Started the game");		
		rb = GetComponent<Rigidbody> ();
	}
	

	void Update () {

		//Handle ball rotation
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		rotation *= Time.deltaTime;
		GetComponent<Rigidbody>().AddRelativeTorque(Vector3.back * rotation);
	
		if (Input.GetKeyDown(KeyCode.W)  && !isFalling) {
			rb.AddForce (Vector3.up * jumpHeight, ForceMode.Impulse);
		}
			
	}

	public void onCollisionStay(Collision col){
		isFalling=false;
	}


}
