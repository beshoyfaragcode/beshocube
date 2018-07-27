using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {
public MeshRenderer Mr ;
public BoxCollider BoxCollide ;
public SphereCollider sp;
public  Transform MY ;

	void Update(){
		

	}
	void OnCollisionEnter(){


MY.position = new Vector3 (1000,1100,5);
Mr.enabled = false ;
sp.enabled = false ;
BoxCollide.enabled = false ;

}

}
