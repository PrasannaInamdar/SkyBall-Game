using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallHealth : MonoBehaviour {
	public float maxFall= -10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= maxFall) {
			SceneManager.LoadScene ("Level1");
			
		}
	}
}
