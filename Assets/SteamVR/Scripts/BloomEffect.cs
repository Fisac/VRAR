using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class BloomEffect : MonoBehaviour {

void OnRenderImage(RenderTexture source, RenderTexture destination){
	
	int width = source.width/2; 
	int height = source.height/2;
    RenderTextureFormat format = source.format;
        
	RenderTexture r = RenderTexture.GetTemporary(
		width, height, 0, format);
	
	Graphics.Blit(source, r);
	Graphics.Blit(destination, r);
	RenderTexture.ReleaseTemporary(r); 
}
}
