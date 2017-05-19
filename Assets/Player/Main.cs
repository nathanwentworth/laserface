using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Main : MonoBehaviour {

	public static Main m;

	public Text scoreText;
	public Text scorePopText;

	public bool paused = true;
	public int score = 0;

	public GameObject HUD;

	// Use this for initialization
	void Start () {
		m = this;
	}

	void Update() {
		if (paused) {
			HUD.SetActive (false);
		} else {
			HUD.SetActive(true);
		}
	}

	public void AddScore(int points) {
		score += points;
		scoreText.text = "" + score;
//		scorePopText.text = "" + points;
		if (scorePopText.GetComponent<Animation> ().isPlaying == true) {
			int scorePopPrevText = Convert.ToInt32 (scorePopText.text, 10);
			scorePopPrevText += points;
			scorePopText.text = "" + scorePopPrevText;
		} else {
			scorePopText.text = "" + points;
		}
		scorePopText.GetComponent<Animation> ().Rewind ();
		scorePopText.GetComponent<Animation> ().Play ();
	}
}
