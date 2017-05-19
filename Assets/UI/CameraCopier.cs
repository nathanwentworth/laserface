using UnityEngine;
using System.Collections;

public class CameraCopier : MonoBehaviour {

	public Transform otherThing;
	

	// Update is called once per frame
	void Update () {
		transform.rotation = otherThing.rotation;
	}
}
