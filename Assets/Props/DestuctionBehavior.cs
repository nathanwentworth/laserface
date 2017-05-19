using UnityEngine;
using System.Collections;

public class DestuctionBehavior : MonoBehaviour {

	public int pointValue = 10;

	public GameObject destructionParticle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void Explode () {
		GameObject particle = Instantiate (destructionParticle, transform.position, transform.rotation) as GameObject;
		Rigidbody newBody = particle.GetComponent<Rigidbody> ();
		newBody.velocity = GetComponent<Rigidbody> ().velocity;
		newBody.angularVelocity = GetComponent<Rigidbody> ().angularVelocity;
		Main.m.AddScore (pointValue);
		Destroy (gameObject);
	}

	void OnCollisionEnter(Collision coll) {
		if (coll.relativeVelocity.sqrMagnitude > 75) {
			Explode ();
		}
	}
}
