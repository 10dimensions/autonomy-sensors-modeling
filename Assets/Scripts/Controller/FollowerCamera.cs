using UnityEngine;
using System.Collections;

public class FollowerCamera : MonoBehaviour{
	
	public float smoothSpeed = 0.125f;
	public Vector3 offset;
	public Transform desiredPosition;

	void FixedUpdate(){
		
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, 
                                  desiredPosition.position+offset, smoothSpeed);
		transform.position = smoothedPosition  ;    

	}
	
}