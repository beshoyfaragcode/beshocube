
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public Transform player;
	public double z ;
	public Text scoretext  ;

	public int scorereal = 0 ;
public float real = 0 ;

	void Update () {
		real  += 0.0000000000000000000001f ;
		double z = player.position.z  - -43.804 ;
		double x = real += 5f;  
		scoretext.text = z.ToString ("0");

		if(scoretext.text == "NaN"){
			scoretext.text = "you made th camra fall you get 100000 ponits ";

			FindObjectOfType< gamemanger> ().Endgame ();

		}
}
}