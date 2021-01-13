using UnityEngine;
using System.Collections;
 
 public class LaserScript : MonoBehaviour
 {
     public LineRenderer laserLineRenderer;
     private float laserWidth = 0.5f;
	 
     [SerializeField] private float laserMaxLength; 
	 [SerializeField] private float angularOffset;
	 [SerializeField] private float frequency;
	 
	 public Transform CarBase;
 
     void Start() {
        Vector3[] initLaserPositions = new Vector3[ 2 ] { Vector3.zero, Vector3.zero };
        laserLineRenderer.SetPositions( initLaserPositions );
        laserLineRenderer.SetWidth( laserWidth, laserWidth );
		 
		StartCoroutine( ProjectLaser( CarBase.position, laserMaxLength ) );  
     }
		
	//Set Laser Parameters Length, Angle, Frequency
     public void SetParameters (float _length, float _angle, float _frequency) 
     {	
		laserMaxLength = _length;
		angularOffset = _angle;
		frequency = _frequency;
     }
		
		
     IEnumerator ProjectLaser( Vector3 targetPosition, float length )
     {	
		 Vector3 direction = Quaternion.Euler(0, angularOffset, 0) * CarBase.forward;	//Offset Ray Angle
		
         Ray ray = new Ray( targetPosition, direction );
         RaycastHit raycastHit;
         Vector3 endPosition = targetPosition + ( length * direction );
			
		  //Raycast from Base
         if( Physics.Raycast( ray, out raycastHit, length ) ) {
             endPosition = raycastHit.point;
         }
		 
		 //Redraw Laser
         laserLineRenderer.SetPosition( 0, targetPosition );
         laserLineRenderer.SetPosition( 1, endPosition );
		 		 
		// Change color based on normalized distance (0 = red, 1 = green)
		float lineColorLength = (endPosition - targetPosition).magnitude / laserMaxLength;
		Color _color = Color.Lerp(Color.red, Color.green, lineColorLength);
		laserLineRenderer.material.color = _color;
			 
		 yield return new WaitForSeconds(frequency);
		 
		 StartCoroutine( ProjectLaser( transform.parent.position, laserMaxLength ) ); 
		 
     }

 }
