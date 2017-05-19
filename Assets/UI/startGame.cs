using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startGame : OculusButton {

	protected override void ButtonAction () {
		base.ButtonAction ();
		Main.m.paused = false;
		// load level 2, keep player object
	}
}
