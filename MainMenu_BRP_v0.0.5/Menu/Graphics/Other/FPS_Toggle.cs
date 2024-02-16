using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Toggle : MonoBehaviour
{
    //found in FPSCounter.cs
    public TMPro.TMP_Dropdown FPSCounterDropDown;
    void Start()
    {
        int val = PlayerPrefs.GetInt("FPS_Counter_Mode");
        FPSCounterDropDown.value = val;
    }

    public void SetFPSCounter(int index)
    {
        PlayerPrefs.SetInt("FPS_Counter_Mode", index);
    }

}
