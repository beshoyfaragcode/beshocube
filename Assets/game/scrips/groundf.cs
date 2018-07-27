using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundf : MonoBehaviour {
public Transform player ;
public Transform mme ;
public float  offset ;	
public float  offsetz ;	
public float  speed;	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
offset = player.transform.position.z + offsetz +speed;

transform.position = new Vector3(mme.transform.position.x,mme.transform.position.y,offset);
//offsetz += speed ;
	}
}
