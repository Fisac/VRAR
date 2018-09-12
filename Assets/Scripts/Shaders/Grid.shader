Shader "Custom/Grid" {
	Properties{
		_GridWidth("Grid Width", Float) = 0.0
		_GridSpacing("Grid Spacing", Float) = 10.0
		_GridColor("Grid Color", Color) = (0.5, 0.5, 0.5, 0.5)
		_BaseColor("Base Color", Color) = (0.0, 0.0, 0.0, 0.0)
	}
		SubShader{
			Tags { "Queue" = "Transparent" }
			Pass {
				ZWrite Off
				Blend SrcAlpha OneMinusSrcAlpha

				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag

				uniform float _GridWidth; 
				uniform float _GridSpacing; 
				uniform float4 _GridColor; 
				uniform float4 _BaseColor; 

				struct vertexInput {
					float4 vertex : POSITION;
				}; 

				struct vertexOutput {
					float4 pos : SV_POSITION; 
					float4 worldPos : TEXCOORD0; 
				}; 

				vertexOutput vert(vertexInput input) {
					vertexOutput output; 
					output.pos = UnityObjectToClipPos(input.vertex);
					output.worldPos = mul(unity_ObjectToWorld, input.vertex); 
					return output; 
				}

				float4 frag(vertexOutput input) :COLOR
				{
					if (frac(input.worldPos.x / _GridSpacing) < _GridWidth || frac(input.worldPos.y / _GridSpacing) < _GridWidth)
					{
						return _GridColor;
					}
					else if (frac(input.worldPos.x / _GridSpacing) < _GridWidth || frac(input.worldPos.z /_GridSpacing) < _GridWidth)
					{
						return _GridColor;
					}
					else
					{
						return _BaseColor;
					}
				}
			ENDCG
			}
		}
	}