
using UnityEngine;
using UnityEngine.SceneManagement;


public class gamemanger : MonoBehaviour {
	public bool gameisover = false ;
	public float delay = 0.5f ;
	public GameObject done ;
	public GameObject scoreh ;
	public GameObject canvas ;
	public GameObject doneone ;
	public GameObject scoreone ;
	public GameObject canvasone ;
	public Rigidbody rb ;
	public GameObject scoredone ;
	public GameObject pusebuton ;
		public GameObject pusebutonpanel ;
		public static int adscount = 0 ;
				public  int editercount = 0 ;
	public float score;
	public float id;
	public float x;
public bool adse;

		
	void Start () {


	}
	public void Endgame (){

		if (gameisover == false){

			gameisover = true;
			Debug.Log ("game over");
			Invoke ("Restart", delay);
		
		}


;
	}
	void Restart (){

adscount += 1;
if(adscount > 2){

AdBuddizBinding.RewardedVideo.Fetch();
		AdBuddizBinding.RewardedVideo.Show();
adscount = 0;
		}


		Debug.Log ("got it");
		done.SetActive (true);
		scoreh.SetActive (true);
		canvas.SetActive (true);
		doneone.SetActive (true);
		scoreone.SetActive (true);
		canvasone.SetActive (true);
    	pusebuton.SetActive (false);   
		pusebutonpanel.SetActive (false);  
		highscore ();
	}

	public void lc (){


	SceneManager.LoadScene ("level 2");
		
       
	}
	void Update(){
		 x = PlayerPrefs.GetFloat ("score");
		id = PlayerPrefs.GetFloat ("score");
		Debug.Log ( "x = " + x);
		editercount = adscount ;

	}
	public void highscore (){
		score = s.realscore;
		if (id == 0) {
			id = score;
			PlayerPrefs.SetFloat ("score", score);
		} else {
			if (score > id) {
				id = score;
				PlayerPrefs.SetFloat ("score", score);
			
					Debug.Log ("hghscor is"+ x);
			} else {
				Debug.Log ("score too small");
			}
		}
		}

				}



