using UnityEngine;

public class MOVMENT1 : MonoBehaviour {
 public GameObject player;
 public Vector3 offset ;	

	void Update () {
		offset.x = -player.transform.position.x + -7.7f ;
		offset.y = -player.transform.position.y;
				transform.position = player.transform.position + offset;
		
		
	}
	

	
}





	











	


