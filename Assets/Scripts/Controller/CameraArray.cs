using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArray : MonoBehaviour
{	
	[SerializeField] private RenderTexture[] CameraArrayStreams;	//0-rgb	1-depth	2-segmentation
	private Camera cam;

    private void Awake()
	{
		cam = GetComponent<Camera>();
	}

	private void Start()
	{
		StartCoroutine(RenderTexturesCoroutine());
	}

	IEnumerator RenderTexturesCoroutine()
	{
		cam.targetTexture = CameraArrayStreams[0];
		yield return new WaitForSeconds(1f);
		cam.Render();
	}

}
