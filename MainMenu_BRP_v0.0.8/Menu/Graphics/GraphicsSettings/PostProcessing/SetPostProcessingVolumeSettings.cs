using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(PostProcessVolume))]
public class SetPostProcessingVolumeSettings : MonoBehaviour
{
    private PostProcessVolume ppVolume;
    private MotionBlur motionBlur;
    // Start is called before the first frame update
    void Start()
    {
        ppVolume = GetComponent<PostProcessVolume>();   
        motionBlur = ppVolume.profile.GetSetting<MotionBlur>();
        if (PlayerPrefs.GetInt("MotionBlur_Setting") == 0)
        {
            motionBlur.active = true;
        }
        if (PlayerPrefs.GetInt("MotionBlur_Setting") == 1)
        {
            motionBlur.active = false;
        }
    }
}
