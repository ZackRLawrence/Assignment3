Shader "Custom/ParticleShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        //Define properties for Start and End Color
    }
    SubShader
    {
        Tags {"Queue"="Transparent" "RenderType"="Opaque" }
        LOD 100
        
        Blend One One
        ZWrite off
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            struct appdata
            {
                float4 vertex : POSITION;
                //Define UV data
            };

            struct v2f
            {   
                float4 vertex : SV_POSITION;
                //Define UV data
            };

            sampler2D _MainTex;
          

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                //o.uv = v.uv; Correct this for particle shader
             
                return o;
            }

            float4 frag (v2f i) : SV_Target
            {
                //Get particle age percentage
                
                //Sample color from particle texture
                
                //Find "start color"
                
                //Find "end color"
                
                //Do a linear interpolation of start color and end color based on particle age percentage
               
                return float4(1,1,1,1);
            }
            ENDCG
        }
    }
}
