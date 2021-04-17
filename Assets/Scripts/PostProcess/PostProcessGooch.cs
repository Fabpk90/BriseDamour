using System;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Rendering;

public class PostProcessGooch : MonoBehaviour
{
    public ComputeShader shader;

    public Light directionalLight;
   // [HideInInspector]
    public RenderTexture sobel;
    public RenderTexture copyTexture;

    private CommandBuffer cmd;
    private void Start()
    {
        sobel = new RenderTexture(Screen.width, Screen.height, 0) {enableRandomWrite = true};
        copyTexture = new RenderTexture(Screen.width, Screen.height, 0) {enableRandomWrite = true};

        

        shader.SetVector("lightDir", directionalLight.transform.forward);
        shader.SetVector("cameraDir", transform.forward);
        shader.SetTexture(0, "Result", sobel);
        shader.SetTexture(1, "sobel", sobel);
        shader.SetTexture(1, "Result", copyTexture);
        
        RenderPipelineManager.endCameraRendering += EndCameraRendering;
    }

    private void OnDestroy()
    {
        RenderPipelineManager.endCameraRendering -= EndCameraRendering;
    }

    private void EndCameraRendering(ScriptableRenderContext arg1, Camera arg2)
    {
        shader.SetVector("cameraDir", transform.forward);

        cmd = new CommandBuffer {name = "gooch"};

        //compute sobel
        cmd.DispatchCompute(shader, 0, Screen.width / 8, Screen.height / 8, 1);
        cmd.DispatchCompute(shader, 1, Screen.width / 8, Screen.height / 8, 1);
        
        cmd.Blit(copyTexture, arg2.activeTexture);
        arg1.ExecuteCommandBuffer(cmd);
    }
}