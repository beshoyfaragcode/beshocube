using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endless : MonoBehaviour {
public Vector3 temp;
public int scale = 10 ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		temp = transform.localScale;
		temp.z += scale;
		transform.localScale = temp;
	}
}
