using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraArray : MonoBehaviour
{	
	[SerializeField] private RenderTexture[] CameraArrayStreams;	//0-rgb	1-depth	2-segmentation
	[SerializeField] private Material DepthMapMat;
	private Camera cam;

    private void Awake()
	{
		cam = GetComponent<Camera>();
		cam.depthTextureMode = DepthTextureMode.Depth;
	}

	private void Start()
	{
		StartCoroutine(RenderTexturesCoroutine());
	}

	IEnumerator RenderTexturesCoroutine()
	{	
		cam.targetTexture = CameraArrayStreams[0];
 
		Graphics.Blit(CameraArrayStreams[0], CameraArrayStreams[1], DepthMapMat);
		//cam.SetTargetBuffers (CameraArrayStreams[1].depthBuffer, CameraArrayStreams[0].colorBuffer);
		
		yield return new WaitForSeconds(1f);
		cam.Render();
		
	}
	
	void OnRenderImage(RenderTexture source, RenderTexture destination)
    {	
		Graphics.Blit(source, destination, DepthMapMat);
    }

}
