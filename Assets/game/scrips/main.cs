using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class main : MonoBehaviour {
public void one (){
	
AdBuddizBinding.RewardedVideo.Fetch();
		AdBuddizBinding.RewardedVideo.Show();
		SceneManager.LoadScene ("highscore");
		hit.hitlife = 6;
	}
}
