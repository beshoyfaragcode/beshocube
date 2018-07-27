using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spown : MonoBehaviour {
public GameObject spawning ;
public Vector3 postion;
public GameObject spawningtwo ;
public GameObject spawningthree;
public GameObject player ;
public GameObject healone ;
public GameObject healtwo ;
public GameObject healthree ;
public GameObject greenlong ;
public bool on ;
	public float minzone; 
public float z ;
public float delay = 5;
public float zone;
	void Start() {

					z = 20 ;
		
	}
	



void Update (){

	
		Invoke ("done" ,delay);
		//StartCoroutine ("heal");
		zone +=48 ;
minzone = player.transform.position.z + z ;
		
}
void done (){

	
		StartCoroutine ("time");
	
		
}
	
	
	public IEnumerator time() {
		
		transform.position = new Vector3 (Random.Range (-19.64f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject six =   Instantiate (greenlong, transform.position, Quaternion.identity)as GameObject;
		transform.position = new Vector3 (Random.Range (-19.64f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject sixpuls =   Instantiate (greenlong, transform.position, Quaternion.identity)as GameObject;
	
		transform.position = new Vector3 (Random.Range (-19.64f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject one =   Instantiate (healone, transform.position, Quaternion.identity)as GameObject;
		transform.position = new Vector3 (Random.Range (-19.64f,7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject onepulsone =   Instantiate (healone, transform.position, Quaternion.identity)as GameObject;
		yield return new WaitForSeconds (5f);
		DestroyImmediate (one,true);
		transform.position = new Vector3 (Random.Range (-19.64f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject two = Instantiate (healtwo, transform.position, Quaternion.identity)as GameObject;
		transform.position = new Vector3 (Random.Range (-19.64f-17.20002f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject twopuls = Instantiate (healtwo, transform.position, Quaternion.identity)as GameObject;
		yield return new WaitForSeconds (5f);
		DestroyImmediate (two,true);
		DestroyImmediate (onepulsone,true);	
		transform.position = new Vector3 (Random.Range (-17.20002f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject three = Instantiate (healthree, transform.position, Quaternion.identity)as GameObject;
		transform.position = new Vector3 (Random.Range (-17.20002f,7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject threepus = Instantiate (healthree, transform.position, Quaternion.identity)as GameObject;
		yield return new WaitForSeconds (5f);
		DestroyImmediate (twopuls,true);
		transform.position = new Vector3 (Random.Range (-19.64f,7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject four = Instantiate (spawning, transform.position, Quaternion.identity)as GameObject;
		transform.position = new Vector3 (Random.Range (-19.64f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject fourpuls = Instantiate (spawning, transform.position, Quaternion.identity)as GameObject;
		yield return new WaitForSeconds (5f);
		DestroyImmediate (three,true);
		yield return new WaitForSeconds (5f);
		DestroyImmediate (four,true);
		yield return new WaitForSeconds (5f);
		DestroyImmediate (threepus,true);
		transform.position = new Vector3 (Random.Range (-19.64f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject five =  Instantiate (spawningtwo, transform.position, Quaternion.identity)as GameObject;
		transform.position = new Vector3 (Random.Range (-19.64f, 7.3f), -1.22f, Random.Range (minzone, zone));
		GameObject fiveplus =  Instantiate (spawningtwo, transform.position, Quaternion.identity)as GameObject;
		yield return new WaitForSeconds (5f);
		DestroyImmediate (five,true);
			DestroyImmediate (fourpuls,true);
			transform.position = new Vector3 (Random.Range (-19.64f, 7.3f), -1.22f, Random.Range (minzone, zone));
		yield return new WaitForSeconds (5f);
		DestroyImmediate (fiveplus,true);
		
	yield return new WaitForSeconds (5f);
	DestroyImmediate (sixpuls,true);
	yield return new WaitForSeconds (5f);

	}
	void die (){


	
	}
	
	
}
	
	
	
	


	


