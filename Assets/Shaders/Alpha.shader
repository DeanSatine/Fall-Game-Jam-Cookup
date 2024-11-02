Shader "Custom/Alpha"
{
    Properties
    {
        _MainTex ("Main Tex", 2D) = "white" {}
        _Color ("Colour", Color) = (0.5, 0.5, 0.5, 0.3)
    }
    SubShader
    {

        Tags {"Queue" = "Transparent"}

        CGPROGRAM

        #pragma surface surf Lambert alpha:fade

        sampler2D _MainTex;
        float4 _Color;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Albedo = _Color.rgb;
            o.Alpha = _Color.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
