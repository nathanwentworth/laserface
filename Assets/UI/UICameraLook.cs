using UnityEngine;
using System.Collections;

public class UICameraLook : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit)) {
			if (hit.collider.tag == "Button") {
				hit.collider.GetComponent<OculusButton>().LookAt();
				Debug.Log ("BUTTON HIT");
			}
		}

	}
}
