using UnityEngine;
using System.Collections;




public class BouncyBall : MonoBehaviour {

	public Transform otransform;
	public float maxDistance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {

		float distance = Vector3.Distance (transform.position, otransform.position);
		if (distance >= maxDistance) {
			Vector3 force =  otransform.position - transform.position;
			rigidbody.AddForce(force);			
	}
}
}
