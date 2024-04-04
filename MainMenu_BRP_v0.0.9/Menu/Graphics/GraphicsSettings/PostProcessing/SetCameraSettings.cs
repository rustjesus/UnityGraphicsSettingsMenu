using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(Camera))]
public class SetCameraSettings : MonoBehaviour
{
    private PostProcessLayer pp_layer;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        pp_layer = GetComponent<PostProcessLayer>();    
        cam = GetComponent<Camera>();
        //very high
        if (PlayerPrefs.GetInt("CameraDistance") == 0)
        {
            cam.farClipPlane = 1000f;
        }
        //high
        if (PlayerPrefs.GetInt("CameraDistance") == 1)
        {
            cam.farClipPlane = 500f;
        }
        //medium
        if (PlayerPrefs.GetInt("CameraDistance") == 2)
        {
            cam.farClipPlane = 300f;
        }
        //low
        if (PlayerPrefs.GetInt("CameraDistance") == 3)
        {
            cam.farClipPlane = 200f;
        }
        //very low
        if (PlayerPrefs.GetInt("CameraDistance") == 4)
        {
            cam.farClipPlane = 150f;
        }

        if (PlayerPrefs.GetInt("AA_Mode") == 0)
        {
            //none
            pp_layer.antialiasingMode = PostProcessLayer.Antialiasing.None;
        }
        if (PlayerPrefs.GetInt("AA_Mode") == 1)
        {
            //FXAA
            pp_layer.antialiasingMode = PostProcessLayer.Antialiasing.FastApproximateAntialiasing;
        }
        if (PlayerPrefs.GetInt("AA_Mode") == 2)
        {
            //SMAA
            pp_layer.antialiasingMode = PostProcessLayer.Antialiasing.SubpixelMorphologicalAntialiasing;
        }
        if (PlayerPrefs.GetInt("AA_Mode") == 3)
        {
            //TAA
            pp_layer.antialiasingMode = PostProcessLayer.Antialiasing.TemporalAntialiasing;
        }
    }

}
