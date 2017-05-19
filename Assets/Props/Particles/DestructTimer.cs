using UnityEngine;
using System.Collections;

public class DestructTimer : MonoBehaviour {

	public float timer = 5f;
	private float timeToDestory  = 0f;

	// Update is called once per frame
	void Update () {
		timeToDestory += Time.deltaTime;
		if (timeToDestory >= timer) {
			Destroy (gameObject);
		}
	}
}
