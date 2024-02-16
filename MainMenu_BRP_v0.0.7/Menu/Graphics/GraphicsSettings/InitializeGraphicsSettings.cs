using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGraphicsSettings : MonoBehaviour
{

    void Start()
    {

        //Very High
        if (PlayerPrefs.GetInt("LodBias") == 0)
        {
            QualitySettings.lodBias = 1f;
        }
        //High
        if (PlayerPrefs.GetInt("LodBias") == 1)
        {
            QualitySettings.lodBias = 0.8f;
        }
        //Medium
        if (PlayerPrefs.GetInt("LodBias") == 2)
        {
            QualitySettings.lodBias = 0.6f;
        }
        //Low   
        if (PlayerPrefs.GetInt("LodBias") == 3)
        {
            QualitySettings.lodBias = 0.4f;
        }
        //Very Low   
        if (PlayerPrefs.GetInt("LodBias") == 4)
        {
            QualitySettings.lodBias = 0.2f;
        }

        //Full
        if (PlayerPrefs.GetInt("TextureSize") == 0)
        {
            QualitySettings.globalTextureMipmapLimit = 1;
        }
        //Half
        if (PlayerPrefs.GetInt("TextureSize") == 1)
        {
            QualitySettings.globalTextureMipmapLimit = 2;
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

        //MIGHT NEED TO RE-ADD!!!

        //Very High
        if (PlayerPrefs.GetInt("ShadowResolutionSize") == 0)
        {
            QualitySettings.shadowResolution = ShadowResolution.VeryHigh;
        }
        //High
        if (PlayerPrefs.GetInt("ShadowResolutionSize") == 1)
        {
            QualitySettings.shadowResolution = ShadowResolution.High;
        }

        //Medium
        if (PlayerPrefs.GetInt("ShadowResolutionSize") == 2)
        {
            QualitySettings.shadowResolution = ShadowResolution.Medium;
        }
        //Low   
        if (PlayerPrefs.GetInt("ShadowResolutionSize") == 3)
        {
            QualitySettings.shadowResolution = ShadowResolution.Low;
        }

        //4
        if (PlayerPrefs.GetInt("ShadowCascadeCount") == 0)
        {
            QualitySettings.shadowCascades = 4;
        }
        //2
        if (PlayerPrefs.GetInt("ShadowCascadeCount") == 1)
        {
            QualitySettings.shadowCascades = 2;
        }
        //0
        if (PlayerPrefs.GetInt("ShadowCascadeCount") == 2)
        {
            QualitySettings.shadowCascades = 0;
        }

        //Very Far
        if (PlayerPrefs.GetInt("ShadowDistance") == 0)
        {
            QualitySettings.shadowDistance = 800;
        }
        //Far
        if (PlayerPrefs.GetInt("ShadowDistance") == 1)
        {
            QualitySettings.shadowDistance = 500;
        }
        //Medium
        if (PlayerPrefs.GetInt("ShadowDistance") == 2)
        {
            QualitySettings.shadowDistance = 350;
        }
        //Low   
        if (PlayerPrefs.GetInt("ShadowDistance") == 3)
        {
            QualitySettings.shadowDistance = 150;
        }
        //Very Low
        if (PlayerPrefs.GetInt("ShadowDistance") == 4)
        {
            QualitySettings.shadowDistance = 80;
        }
        //OFF
        if (PlayerPrefs.GetInt("ShadowDistance") == 5)
        {
            QualitySettings.shadowDistance = 0;
        }

        //set aa level
        if (PlayerPrefs.GetInt("AntiAliasingIndex") == 0)
        {
            QualitySettings.antiAliasing = 2;
        }
        if (PlayerPrefs.GetInt("AntiAliasingIndex") == 1)
        {
            QualitySettings.antiAliasing = 4;
        }
        if (PlayerPrefs.GetInt("AntiAliasingIndex") == 2)
        {
            QualitySettings.antiAliasing = 8;
        }

        //On
        if (PlayerPrefs.GetInt("SoftParticles") == 0)
        {
            QualitySettings.softParticles = false;
        }
        //off
        if (PlayerPrefs.GetInt("SoftParticles") == 1)
        {
            QualitySettings.softParticles = false;
        }

    }

}
