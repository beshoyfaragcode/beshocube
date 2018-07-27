using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distory : MonoBehaviour {
	public GameObject Player ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if(this.gameObject.transform.position.z < Player.transform.position.z ){

           DestroyImmediate(this.gameObject);

			}

	}
}
