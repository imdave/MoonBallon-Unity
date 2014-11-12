using UnityEngine;
using System.Collections;

public class Trampoline : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
	
			


		Vector3 reflectingVector = Vector3.Reflect (other.attachedRigidbody.velocity, Vector3.up);
		Debug.DrawRay (other.transform.position, reflectingVector);

		float rotation = 90 - Mathf.Atan2 (reflectingVector.y, reflectingVector.x) * Mathf.Rad2Deg;
		//other.transform.eulerAngles = new Vector3(0,rotation, 0);
		other.attachedRigidbody.velocity = new Vector3(other.attachedRigidbody.velocity.x, reflectingVector.y, other.attachedRigidbody.velocity.z);
		

		//other.transform.position = new Vector3 (other.transform.position.x, other.transform.position.y + 1, other.transform.position.z);
	}

	void onCollisionEnter(Collision collision) {
		Debug.Log ("bounce");

		Vector3 normal = collision.contacts [0].normal;
		Vector3 reflectingVector = Vector3.Reflect (collision.collider.attachedRigidbody.velocity, normal);
		Debug.DrawRay(collision.collider.transform.position, normal);
		                                        
	

	}
}
