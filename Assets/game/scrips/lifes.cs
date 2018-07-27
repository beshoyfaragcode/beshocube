using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifes : MonoBehaviour{
	public Text lifesonetext;
public GameObject lifesgo ;
public float lifesthree ;
public hit script;

	void Start(){

 lifesgo.GetComponent<hit>();
	}
	void Update () {
		lifesonetext.text = hit.hitlife.ToString()  ; 
		
		 

	}

}
