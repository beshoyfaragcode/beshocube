using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {
	public AudioSource bf ;

	void OnCollisionStay(Collision col){


bf.volume = 1;
bf.Play() ;
	}
}
