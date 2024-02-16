using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSizeSettings : MonoBehaviour
{
    public TMPro.TMP_Dropdown TextureSizeDropDown;
    void Start()
    {
        int val = PlayerPrefs.GetInt("TextureSize");
        TextureSizeDropDown.value = val;
    }

    public void SetTextureSize(int index)
    {
        PlayerPrefs.SetInt("TextureSize", index);
    }
    public void UpdatePreset()
    {
        //allows to change after preset swap
        int val = PlayerPrefs.GetInt("TextureSize");
        TextureSizeDropDown.value = val;
        //Full
        if (PlayerPrefs.GetInt("TextureSize") == 0)
        {
            QualitySettings.globalTextureMipmapLimit = 0;
        }
        //Half
        if (PlayerPrefs.GetInt("TextureSize") == 1)
        {
            QualitySettings.globalTextureMipmapLimit = 1;
        }
        //Quarter
        if (PlayerPrefs.GetInt("TextureSize") == 2)
        {
            QualitySettings.globalTextureMipmapLimit = 2;
        }
        //Eighth
        if (PlayerPrefs.GetInt("TextureSize") == 3)
        {
            QualitySettings.globalTextureMipmapLimit = 3;
        }
        //Sixteenth
        if (PlayerPrefs.GetInt("TextureSize") == 4)
        {
            QualitySettings.globalTextureMipmapLimit = 4;
        }
    }
}
