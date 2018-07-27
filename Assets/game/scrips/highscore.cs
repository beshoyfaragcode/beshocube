using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highscore : MonoBehaviour {
	public Text highscoretext ;
	// Use this for initialization
	void Start () {
		highscoretext.text = "high score is" +" "+ PlayerPrefs.GetFloat ("score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
