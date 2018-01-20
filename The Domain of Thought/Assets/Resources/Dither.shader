Shader "Dither" {
	Properties {
	 	_MainTex ("", 2D) = "white" {}
	}
	SubShader {
	 	Pass {
	  		CGPROGRAM
	  		#pragma vertex vert_img
	  		#pragma fragment frag
	  		#include "UnityCG.cginc"

	  		uniform sampler2D _MainTex;

			float luma(fixed3 color) {
				return dot(color, fixed3(0.8, 0.8, 0.8));
			}

			fixed4 ditherBayer2(fixed2 position, float brightness) {
				int x = fmod(position.x, 4.0);
                int y = fmod(position.y, 4.0);

                float4x4 lim = {
                0.2, 0.6, 0.2, 0.7,
                0.9, 0.3, 0.9, 0.4,
                0.2, 0.8, 0.2, 0.6,
                1.0, 0.5, 0.9, 0.4
                };

                if (brightness < lim[y][x]) return fixed4(0.0, 0.0, 0.0, 0.0);
               	
                return fixed4(1.0, 1.0, 1.0, 1.0);
			}

			fixed3 ditherBayer(fixed2 position, fixed3 col) {
				return ditherBayer2(position, luma(col));
			}

	  		fixed4 frag (v2f_img i) : COLOR {
	   			fixed3 col = tex2D (_MainTex, i.uv).rgb;
				return fixed4(ditherBayer(i.pos.xy, col), 1.0);
	  		}
	  		ENDCG
	 	}
	}
}