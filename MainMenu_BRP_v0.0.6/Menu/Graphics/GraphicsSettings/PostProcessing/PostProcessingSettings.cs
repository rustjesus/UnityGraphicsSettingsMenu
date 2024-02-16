using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PostProcessingSettings : MonoBehaviour
{
    public TMP_Dropdown CameraDistanceDropDown;
    public TMP_Dropdown motionBlurDropdown;

    void Start()
    {

        int val4 = PlayerPrefs.GetInt("MotionBlur_Setting");
        motionBlurDropdown.value = val4;

        int val = PlayerPrefs.GetInt("CameraDistance");
        CameraDistanceDropDown.value = val;
    }

    public void SetMotionBlur(int index)
    {
        PlayerPrefs.SetInt("MotionBlur_Setting", index);
    }
    public void SetCamDistance(int index)
    {
        PlayerPrefs.SetInt("CameraDistance", index);
    }
    public void UpdatePreset()
    {
        Start();


    }

}
