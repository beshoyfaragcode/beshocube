using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour {
	public GameObject lifesgo ;


	void Start (){
		Time.timeScale = 1;
		lifesgo.GetComponent<hit>();

	}
	public void Restart (){
AdBuddizBinding.RewardedVideo.Fetch();
		AdBuddizBinding.RewardedVideo.Show();
SceneManager.LoadSceneAsync ("level 1");
		hit.hitlife = 6;
	}

}
