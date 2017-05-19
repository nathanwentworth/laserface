using UnityEngine;
using System.Collections;

public class VehicleBehavior : MonoBehaviour {
	private bool hasScored = false;
	public int scoreValue = 300;
	void Explode() {
		if (!hasScored) {
			hasScored = true;
			Main.m.AddScore(scoreValue);
		}
	}

}
