using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseGraphicsSettings : MonoBehaviour
{
    // TMP_Dropdown qualityDropdown;
    public TMP_Dropdown vSyncDropdown;
    public TMP_Dropdown antiAliasingDropdown;
    public TMP_Dropdown antiAliasingModeDropdown;
    private void Awake()
    {

        // VSync Settings 
        vSyncDropdown.ClearOptions();

        List<string> vSyncOptions = new List<string>() { "V-Sync Off", "V-Sync On" };

        vSyncDropdown.AddOptions(vSyncOptions);
        vSyncDropdown.value = PlayerPrefs.GetInt("VSync");
        vSyncDropdown.RefreshShownValue();
        //enable/disable vsync on start
        if (PlayerPrefs.GetInt("VSync") == 0)
        {
            QualitySettings.vSyncCount = 0;
        }
        if (PlayerPrefs.GetInt("VSync") == 1)
        {
            QualitySettings.vSyncCount = 1;
        }

        // Anti-Aliasing Settings 
        antiAliasingDropdown.ClearOptions();

        List<string> aaOptions = new List<string>() { "2x", "4x", "8x" };

        antiAliasingDropdown.AddOptions(aaOptions);
        antiAliasingDropdown.value = PlayerPrefs.GetInt("AntiAliasingIndex");
        antiAliasingDropdown.RefreshShownValue();


        int val = PlayerPrefs.GetInt("AA_Mode");
        antiAliasingModeDropdown.value = val;


        if (PlayerPrefs.GetInt("AA_Mode") > 0)
        {
            antiAliasingDropdown.gameObject.SetActive(true);
        }
        else
        {

            antiAliasingDropdown.gameObject.SetActive(false);
        }
    }
    public void SetAA_Mode(int index)
    {
        PlayerPrefs.SetInt("AA_Mode", index);

        if (PlayerPrefs.GetInt("AA_Mode") > 0)
        {
            antiAliasingDropdown.gameObject.SetActive(true);
        }
        else
        {

            antiAliasingDropdown.gameObject.SetActive(false);
        }
    }

    public void SetQuality(int qualityIndex)
    {
        // Save quality level to PlayerPrefs 
        PlayerPrefs.SetInt("QualityLevel", qualityIndex);
        QualitySettings.SetQualityLevel(qualityIndex);


    }

    public void SetVSync(int vSyncIndex)
    {
        // Save vSync setting to PlayerPrefs 
        PlayerPrefs.SetInt("VSync", vSyncIndex);
        QualitySettings.vSyncCount = vSyncIndex;
    }

    public void SetAntiAliasing(int antiAliasingIndex)
    {
        // Save anti-aliasing setting to PlayerPrefs 
        PlayerPrefs.SetInt("AntiAliasingIndex", antiAliasingIndex);
    }

    public void UpdatePreset()
    {
        //allows to change after preset swap
        int val = PlayerPrefs.GetInt("AntiAliasingIndex");
        antiAliasingDropdown.value = val;

        int val2 = PlayerPrefs.GetInt("AA_Mode");
        antiAliasingModeDropdown.value = val2;

    }
}
