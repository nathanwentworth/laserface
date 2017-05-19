using UnityEngine;
using System.Collections;

public class tutorialButton : OculusButton {

	public GameObject ButtonTut;
	public GameObject tutorial;

	protected override void ButtonAction ()
	{
		base.ButtonAction();
		tutorial.SetActive(true);
		ButtonTut.SetActive(false);
	}
}