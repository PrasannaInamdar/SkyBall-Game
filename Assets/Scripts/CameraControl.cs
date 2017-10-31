	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class CameraControl : MonoBehaviour {

		public Transform target;
		public float distance=-10;
		public float lift = 1.5f;
		public Vector3 offset;

		// Use this for initialization
		void Start () {
			offset = new Vector3 (0, lift, distance);
		}
		
		// Update is called once per frame
		void Update () {
			transform.position = target.position + offset;
			transform.LookAt (target);
		}
	}
