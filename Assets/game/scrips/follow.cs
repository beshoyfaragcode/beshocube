using UnityEngine;

public class follow : MonoBehaviour {

public Transform player ;
public Vector3 offset ;	
	public Vector3 NaN  ;

	// Update is called once per frame
	void Update () {

	
		NaN = new Vector3(0.001f, 0.001f, 0.001f);
	


				transform.position = player.position + offset + NaN;
	

		}
}