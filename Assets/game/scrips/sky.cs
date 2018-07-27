using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sky : MonoBehaviour {
	public Skybox sb ;

public Material skyone;
public Material skytwo;

	// Use this for initialization
	void Start () {
	
		
	}
	public void any () {
	
		sb.material = skytwo ;
	}
	public void re() {
	
		sb.material = skyone ;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
