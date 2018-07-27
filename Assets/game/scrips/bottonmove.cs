using UnityEngine;

public class bottonmove : MonoBehaviour {
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
	
	public void right () {
			rb.AddForce (forceside * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


		}
	public void left() {

			rb.AddForce (-forceside * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


		}
    
public void jumpbottn() {
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





	











	


