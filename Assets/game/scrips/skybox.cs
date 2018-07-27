using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox : MonoBehaviour {
	public Material skyone ;
		public Material skytwo ;
			public Material skythree ;

	// Use this for initialization
	void Start () {
		RenderSettings.skybox = skyone ;
		
			}
	
	// Update is called once per frame
	void Update () {
		
	}
}
