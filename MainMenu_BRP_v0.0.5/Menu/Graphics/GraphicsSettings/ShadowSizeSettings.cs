using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowSizeSettings : MonoBehaviour
{
    public TMPro.TMP_Dropdown ShadowResSizeDropDown;
    public TMPro.TMP_Dropdown ShadowCascadeDropDown;
    void Start()
    {
        int val = PlayerPrefs.GetInt("ShadowResolutionSize");
        ShadowResSizeDropDown.value = val;

        int val2 = PlayerPrefs.GetInt("ShadowCascadeCount");
        ShadowCascadeDropDown.value = val2;
    }

    public void SetShadowResSize(int index)
    {
        PlayerPrefs.SetInt("ShadowResolutionSize", index);



    }
    public void SetShadowCascadeCount(int index)
    {
        PlayerPrefs.SetInt("ShadowCascadeCount", index);



    }

    public void UpdatePreset()
    {
        //allows to change after preset swap
        int val = PlayerPrefs.GetInt("ShadowResolutionSize");
        ShadowResSizeDropDown.value = val;


        //allows to change after preset swap
        int val2 = PlayerPrefs.GetInt("ShadowCascadeCount");
        ShadowCascadeDropDown.value = val2;


    }

}
