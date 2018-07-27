using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showad : MonoBehaviour {
public static bool beenhere = false ;
public bool beenhereediter ;
	// Use this for initialization
	void Start () {
				if(beenhere ){
AdBuddizBinding.ShowAd();

		}
	}
	
	// Update is called once per frame
	void Update () {
				 beenhereediter = beenhere;
	}
}
