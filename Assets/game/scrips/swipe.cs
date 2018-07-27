using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class swipe : MonoBehaviour
{
public bool tap,swipeleft,swiperight,swipeup,swipedown;
public bool isdraging = false;
public Vector2 starttouch,swipedelta; 
public Rigidbody rb;
public AudioSource jm;
public float forceside = 500f;
public bool jumpon ;

public float jump = 0.942f;
public float jumpspeed = 3;
void Update (){




	if (Input.touchCount >=2 && jumpon == true  ){


			StartCoroutine ("jumptime");
			 jm.volume = 100;
                jm.Play() ;

	}

 tap = swipeleft = swiperight = swipeup = swipedown = false;
if(Input.touches.Length > 0){
if(Input.touches[0].phase == TouchPhase.Began){
isdraging = true;
tap  = true;
starttouch = Input.touches[0].position;

}
else if ( Input.touches[0].phase == TouchPhase.Ended ||Input.touches[0].phase == TouchPhase.Canceled ) {
isdraging = true;
Reset();

}
swipedelta = Vector2.zero;
if(isdraging){


if(Input.touches.Length > 0)

swipedelta = Input.touches[0].position - starttouch;

else if (Input.GetMouseButton(0))
swipedelta = (Vector2)Input.mousePosition - starttouch;




}
if (swipedelta.magnitude > 100)
{



float x = swipedelta.x ;
float y = swipedelta.y ;

if (Mathf.Abs(x) >Mathf.Abs(y)){

if (x < 0) {
swipeleft = true ;
	rb.AddForce (-forceside * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
}

	else if (x > 0){
	 swiperight = true ;

	rb.AddForce (forceside * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
	}
	

	
else if(Mathf.Abs(x) < Mathf.Abs(y)){

if (y < 0){
	
	swipedown = true;
}
	else if (y > 0 && jumpon == true){ swipeup = true ;
	
			StartCoroutine ("jumptime");
			 jm.volume = 100;
                jm.Play() ;
	}
		}
	
}





Reset();

}

}
}
 public void Reset (){

	starttouch = swipedelta = Vector2.zero ;
	isdraging = false;
}
System.Collections.IEnumerator jumptime() {
		jumpon = false;
		transform.position = new Vector3(transform.position.x,transform.position.y + jump , transform.position.z + jumpspeed);
		yield return new WaitForSeconds (0.5f);
		transform.position = new Vector3 (transform.position.x, -1.22f, transform.position.z);
		jumpon = true;
	}
}


