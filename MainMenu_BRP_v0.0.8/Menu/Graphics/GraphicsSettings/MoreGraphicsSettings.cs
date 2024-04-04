using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreGraphicsSettings : MonoBehaviour
{
    public TMPro.TMP_Dropdown LodBiasDropDown;
    public TMPro.TMP_Dropdown softParticlesDropDown;
    void Start()
    {
        int val = PlayerPrefs.GetInt("LodBias");
        LodBiasDropDown.value = val;

        int val2 = PlayerPrefs.GetInt("SoftParticles");
        softParticlesDropDown.value = val2;
    }

    public void SetLodBias(int index)
    {
        PlayerPrefs.SetInt("LodBias", index);
    }
    public void SetsoftParticles(int index)
    {
        PlayerPrefs.SetInt("SoftParticles", index);
    }

    public void UpdatePreset()
    {
        Start();

       
    }
}