using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class restartButton : OculusButton {

	public GameObject ButtonRestart;
	public Text GameOverScore;
	
	protected override void ButtonAction ()
	{
		base.ButtonAction();
		Application.LoadLevel(0);
		GameOverScore.text = Main.m.score + "";
	}
}