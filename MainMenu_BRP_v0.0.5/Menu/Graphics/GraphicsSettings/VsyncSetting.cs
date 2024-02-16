using UnityEngine;
public class VsyncSetting : MonoBehaviour
{

    [Header("V-Sync Setting")]

    public TMPro.TMP_Dropdown VsyncSettingDropDown;

    void Start()
    {
        int val = PlayerPrefs.GetInt("VysncMode");
        VsyncSettingDropDown.value = val;
    }

    public void SetVysncMode(int index)
    {
        //QualitySettings.SetQualityLevel(index);
        PlayerPrefs.SetInt("VysncMode", index);
    }

    private void UpdatePreset()
    {
        //on
        if (PlayerPrefs.GetInt("VysncMode") == 0)
        {
            QualitySettings.vSyncCount = 1;
        }
        //off
        if (PlayerPrefs.GetInt("VysncMode") == 1)
        {
            QualitySettings.vSyncCount = 0;
        }
    }
}