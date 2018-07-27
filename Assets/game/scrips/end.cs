using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour {
public void doExitGame() {
	AdBuddizBinding.ShowAd();
		Application.Quit();
			AdBuddizBinding.ShowAd();
	}
}
