using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AA_Setting : MonoBehaviour
{
    public TMPro.TMP_Dropdown aaSettingDropDown;

    void Start()
    {
        int val = PlayerPrefs.GetInt("AntiAliasingLevel");
        aaSettingDropDown.value = val;
    }

    public void SetAA_Mode(int index)
    {
        QualitySettings.antiAliasing = index * 2;
        PlayerPrefs.SetInt("AntiAliasingLevel", index * 2);
        Debug.Log("AA =" +index);
    }

}
