Shader "Custom/Foreground"
{
    Properties
    {
        _Color ("Colour", Color) = (1,1,1,1)
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {

        Tags { "Queue"="Geometry+1" }

        ZWrite off
        
        Stencil
        {
            Ref 1
            Comp notequal
            Pass IncrSat
        }

        CGPROGRAM

        #pragma surface surf Lambert

        struct Input
        {
            float2 uv_MainTex;
        };
        
        sampler2D _MainTex;
        fixed4 _Color;

        void surf (Input IN, inout SurfaceOutput o)
        {
            o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb * _Color;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
