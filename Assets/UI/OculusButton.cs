using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OculusButton : MonoBehaviour {

	public float lookTimeToActivate = 2f;
	private float lookTimer = 0f;
	private int framesSinceLookedAt = 5;
	public int lookBuffer = 5;

	public Image timerFill;

	 void Update() {
		if (framesSinceLookedAt < lookBuffer) {
			lookTimer += Time.deltaTime;
			framesSinceLookedAt++;
			if (lookTimer >= lookTimeToActivate) {
				ButtonAction ();
				lookTimer = 0f;
			}
		} else {
			lookTimer -= Time.deltaTime;
			if (lookTimer <= 0f) {
				lookTimer = 0f;
			}
		}
		timerFill.fillAmount = lookTimer/lookTimeToActivate;
	}

	protected virtual void ButtonAction() {
		//Extend this class and write the function here for what button do
		enabled = false;
		
	}

	public void LookAt() {
		framesSinceLookedAt = 0;
	}


}


// timerFill.fillAmount += 1.0f/lookTimer * Time.deltaTime;