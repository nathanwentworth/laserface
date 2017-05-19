using UnityEngine;
using System.Collections;

public class StartButton : OculusButton {

	public GameObject ButtonStart;
	public GameObject ButtonQuit;
	public GameObject ButtonInstruction;
	public GameObject title;

	protected override void ButtonAction ()
	{
		base.ButtonAction();
		Main.m.paused = false;
		ButtonStart.SetActive(false);
		ButtonQuit.SetActive(false);
		ButtonInstruction.SetActive (false);
		title.SetActive (false);

	}
}