
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms ;

public class s : MonoBehaviour {
	public Transform player;
	public float zduble ;
	public static float realscore  ;
	public Text scoretext  ;

	public int scorereal = 0 ;
	public double beshoy = 100 ;
	public double beshoytwo = 700 ;
public float real = 0 ;
public Material skyone;
public Material skytwo;
	public int id = 0 ;
	void Start (){


}
	void Update () {
		
		realscore = Mathf.Round (zduble);
		Debug.Log (realscore);
		double z = player.position.z  - -43.804 ;
		scoretext.text = zduble.ToString ("0");
		zduble = (float)z;






 
		if(scoretext.text == "NaN"){
			scoretext.text = "you made th camra fall you get 100000 ponits ";

			FindObjectOfType< gamemanger> ().Endgame ();

		}
		if( scoretext.text == 100.ToString()) {
		
			Debug.Log ("100");
   
        FindObjectOfType< sky> ().any();
	
		}
		if( scoretext.text == 400.ToString()) {
			Debug.Log ("400");
        FindObjectOfType<sky> ().re();
	

		
			
}
	}


              

        



}
