 using UnityEngine;
 using System.Collections;
 
 public class Scanner : MonoBehaviour {
	
	[SerializeField] public float LaserFrequency;  
	[SerializeField] public float LaserLength;  
	
	[Range(1 , 36)]
	public int FOV;
	
	public GameObject[] LaserNodes;
	public GameObject LaserNodeRef;
	
	void Start() {
		
		for(int i=0; i<360; i=i+(360/FOV)){
			
			Debug.Log(i);
			
			GameObject _laserNode = Instantiate(LaserNodeRef, this.transform.position, this.transform.rotation) as GameObject;
			_laserNode.transform.parent = this.transform;
			_laserNode.SetActive(true);
			
		}
		
	}
	 
 }