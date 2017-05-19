using UnityEngine;
using System.Collections;

public class buttonQuit : OculusButton {

	protected override void ButtonAction ()
	{
		base.ButtonAction ();
		Debug.Log("quit game");
		Application.Quit();
	}
}