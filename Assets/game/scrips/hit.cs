using UnityEngine;

public class hit : MonoBehaviour {
public MOVMENT move ;
public static float hitlife ;
	public GameObject healone ;
	public GameObject healtwo ;
	public GameObject healthree ;
	 public Rigidbody rb;
	 public AudioSource bf;
			 public AudioSource oh ;
	  public AudioSource ic;
	  public ParticleSystem ex;
public float lifes = 6;


	



void Start (){

 hitlife = lifes ;


}
void time(){




}
void OnCollisionEnter (Collision info ){

		if (info.collider.tag == "obstacle") {
                
			hitlife = hitlife - 1;
			Debug.Log (hitlife);
			bf.volume = 1;
              bf.Play() ;
			    ex.Play() ;
			Invoke ("ss",1f);
			
		}
		
		if (info.collider.tag == "helth") {
			DestroyImmediate (healone, true);
			hitlife = hitlife + 0.5f;
            bf.volume = 1;
            bf.Play() ;
			  ex.Play() ;
			Invoke ("ss",1f);
		}
		if(hitlife <= 0 ){
			   bf.volume = 1;
                    bf.Play() ;
			FindObjectOfType< trunoff> ().trunoffone ();
			FindObjectOfType< gamemanger> ().Endgame ();	
			move.enabled = false;
     
		}
		if (hitlife <= 0.5 ){
			   bf.volume = 100;
                bf.Play() ;
			FindObjectOfType< trunoff> ().trunoffone ();
            FindObjectOfType< gamemanger> ().Endgame ();	
			move.enabled = false;
			hitlife = 0;
		}
		if (info.collider.tag == "wall") {
                
			oh.volume = 100;
                oh.Play() ;
			    
			Invoke ("ss",1f);
			
		}
}

void ss (){


oh.Stop();

		ex.Stop();


		
}
}
		
		
	
	









