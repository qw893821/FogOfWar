Shader "Custom/FoWFliter"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Vert("VertSize",float) = 60
		_Hor("HorSize",float) = 60 
	}
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			int _Vert;
			int _Hor;
			sampler2D _MainTex;
			fixed4 frag (v2f i) : SV_Target
			{
				half4 col;
				half4 dark = (1.0, 0.0, 0.0, 0.0);
				
				//col = lerp(dark, tex2D(_MainTex, i.uv), step(0.0, (i.vertex.y - 150)*(400 - i.vertex.y)));
				//col = lerp(tex2D(_MainTex, i.uv) , dark, step(0.0,350-i.vertex.x));
				//col = lerp(dark, tex2D(_MainTex, i.uv), step(0.0, (i.vertex.y - 150)*(400 - i.vertex.y)*(i.vertex.x - 350)*(600 - i.vertex.x)));
				col = lerp(dark, tex2D(_MainTex, i.uv), step(0.0, (i.vertex.y - 150)*(400 - i.vertex.y)));
				col = saturate(col);
				return col;
			}
			ENDCG
		}
	}
}
