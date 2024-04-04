using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowDistanceSetting : MonoBehaviour
{
    public TMPro.TMP_Dropdown ShadowDistanceDropDown;
    void Start()
    {
        int val = PlayerPrefs.GetInt("ShadowDistance");
        ShadowDistanceDropDown.value = val;
    }

    public void SetShadowDistance(int index)
    {
        PlayerPrefs.SetInt("ShadowDistance", index);

    }
    public void UpdatePreset()
    {
        //allows to change after preset swap
        int val = PlayerPrefs.GetInt("ShadowDistance");
        ShadowDistanceDropDown.value = val;

    }
}
