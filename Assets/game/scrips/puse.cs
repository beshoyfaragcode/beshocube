using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puse : MonoBehaviour {

	public GameObject donep ;
	public GameObject scorehp ;
	public GameObject canvasp ;
	public GameObject doneonep ;
	public GameObject scoreonep ;
	public GameObject canvasonep ;
	public GameObject black;
	public Rigidbody rb ;
	public GameObject player ;
	public GameObject playert ;
	public MOVMENT m ;
	public float force ;
public void bf (){


		donep.SetActive (true);
		scorehp.SetActive (true);
		canvasp.SetActive (true);
		doneonep.SetActive (true);
		Time.timeScale = 0;
		canvasonep.SetActive (false);
		player.SetActive (true);
		/*scoreonep.SetActive (true);
		black.SetActive (true);
		canvasonep.SetActive (false);
		player.SetActive (false);
		m.enabled = false;*/
       
	
}
public void on (){


		
	donep.SetActive (false);
		scorehp.SetActive (false);
		canvasp.SetActive (false);
		doneonep.SetActive (false);
		canvasonep.SetActive (true);
		Time.timeScale = 1;
		player.SetActive (false);
	
}
}
