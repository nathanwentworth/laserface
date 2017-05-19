using UnityEngine;
using System.Collections;

public class pause : OculusButton {

	public GameObject Player;
	public GameObject pauseMenu;

	protected override void ButtonAction() {
		pauseMenu.transform.position = Player.transform.position;
		pauseMenu.SetActive(true);
		Time.timeScale = 0;
		gameObject.SetActive(false);
	}
}