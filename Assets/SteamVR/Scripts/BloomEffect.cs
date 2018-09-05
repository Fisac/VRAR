using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class BloomEffect : MonoBehaviour {

void OnRenderImage(RenderTexture source, RenderTexture destination){
	
	int width = source.width/2; 
	int height = source.height/2; 
	RenderTexture r = RenderTexture.GetTemporary(
		source.width, source.height, 0, source.format
	);
	
	Graphics.Blit(source, r); 
	Graphics.Blit(destination, r);
	RenderTexture.ReleaseTemporary(r); 
}
}
