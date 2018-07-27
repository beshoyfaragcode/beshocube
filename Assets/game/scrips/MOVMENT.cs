using UnityEngine;

public class MOVMENT : MonoBehaviour {
 public Rigidbody rb;
public float force = 2000f;
public float forceside = 500f;
public float jump = 0.942f;
public float jumpspeed = 3;
public float delay= 1;
public bool jumpon = true;
	public bool fall = true;
	public MOVMENT move ;
public AudioSource oh ;

public AudioSource jm;
public float maxtime;
public float mindist;
public float st;
public float end;
public Vector3 stpos;
public Vector3 endpos;
public float d;
float swipetime ;
	void fallt (){
		if (fall == true){
		hit.hitlife = hit.hitlife - 1 ;
		fall = false ;
		
		StartCoroutine ("falltwo");
		}
		if (hit.hitlife == 0){
	move.enabled = false;
     rb.position = new Vector3 ( -6.25f , -1.22f, rb.position.z );
		}
	}
	void Update () {
			rb.AddForce (0, 0, force * Time.deltaTime,ForceMode.VelocityChange );
		
		
			
		if (rb.position.y < -2.22f) {
	           oh.volume = 100;
                oh.Play() ;
			Invoke ("fallt", 1f);
		}
				
		if (rb.position.y > 4f) {
	          
			StartCoroutine ("falltwo");
		}


if (Input.GetKey ("right")) {

			rb.AddForce (forceside * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


		}
		if (Input.GetKey ("left")) {

			rb.AddForce (-forceside * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


		}
    
		if (Input.GetKey ("space") && jumpon == true) {
	
			StartCoroutine ("jumptime");
			 jm.volume = 100;
	     jm.Play() ;
			
		
	}
	

	}
		public void right () {
			Debug.Log("right");
			rb.AddForce (forceside * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


		}
	public void left() {
Debug.Log("left");
			rb.AddForce (-forceside * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


		}
    
public void jumpbottn() {
	Debug.Log("jump");
	if (jumpon)
	{
					StartCoroutine ("jumptime");
			 jm.volume = 100;
	     jm.Play() ;		
	}
}
	System.Collections.IEnumerator jumptime() {
		jumpon = false;
		transform.position = new Vector3(transform.position.x,transform.position.y + jump , transform.position.z + jumpspeed);
		yield return new WaitForSeconds (0.5f);
		transform.position = new Vector3 (transform.position.x, -1.22f, transform.position.z);
		jumpon = true;
	}
	System.Collections.IEnumerator falltwo() {
		transform.position = new Vector3 (-6.25f, -1.22f, transform.position.z);
		rb.mass = 7000;
		yield return new WaitForSeconds (1f);
		rb.mass = 4;
		fall = true;

	}
}






	











	


