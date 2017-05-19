using UnityEngine;
using System.Collections;

public class CopterBehavior : MonoBehaviour {
	private bool hasScored = false;
	public int scoreValue = 300;
	public float rotateSpeed = 10f;
	public float moveSpeed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hasScored == false) {
			Vector3 transformVector = new Vector3 (transform.forward.x, -transform.forward.y, 0);
			transform.Translate (transformVector * moveSpeed * Time.deltaTime);
			transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
		}
	}


	void Explode() {
		if (!hasScored) {
			hasScored = true;
			Main.m.AddScore(scoreValue);
			GetComponent<Rigidbody>().useGravity = true;
		}
	}
}
