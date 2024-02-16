using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PresetsGraphicsSetting : MonoBehaviour
{

    public TMPro.TMP_Dropdown PresetsSettingDropDown;
    public GameObject settingsObj;
    private bool done;
    [SerializeField] private TextureSizeSettings textureSizeSettings;
    [SerializeField] private ShadowDistanceSetting shadowDistanceSetting;
    [SerializeField] private ShadowSizeSettings shadowSizeSettings;
    [SerializeField] private BaseGraphicsSettings graphicsSettings;
    [SerializeField] private MoreGraphicsSettings moreGraphicsSettings;
    [SerializeField] private GPUI_GraphicsSettings gpui_GraphicsSettings;
    [SerializeField] private PostProcessingSettings postProcessingSettings;
    void Start()
    {
        if (PlayerPrefs.GetInt("Graphics_FirstLoad") == 0)
        {
            PlayerPrefs.SetInt("Graphics_Preset", 1);//set very high first load
            PlayerPrefs.SetInt("Graphics_FirstLoad", 1);
        }
        textureSizeSettings = FindObjectOfType<TextureSizeSettings>();
        shadowDistanceSetting = FindObjectOfType<ShadowDistanceSetting>();
        shadowSizeSettings = FindObjectOfType<ShadowSizeSettings>();
        graphicsSettings = FindObjectOfType<BaseGraphicsSettings>();
        moreGraphicsSettings = FindObjectOfType<MoreGraphicsSettings>();
        gpui_GraphicsSettings = FindObjectOfType<GPUI_GraphicsSettings>();
        postProcessingSettings = FindObjectOfType<PostProcessingSettings>();
        done = false;
        int val = PlayerPrefs.GetInt("Graphics_Preset");
        PresetsSettingDropDown.value = val;
    }

    public void SetGraphicsPreset(int index)
    {
        //QualitySettings.SetQualityLevel(index);
        PlayerPrefs.SetInt("Graphics_Preset", index);
        done = false;
        //custom
        if (index == 0)
        {
            if (done == false)
            {
                settingsObj.SetActive(true);
                done = true;

            }
        }
        //Very High
        if (index == 1)
        {
            if (done == false)
            {
                //textures
                settingsObj.SetActive(false);
                textureSizeSettings.SetTextureSize(0);
                textureSizeSettings.UpdatePreset();
                //shadows
                shadowDistanceSetting.SetShadowDistance(0);
                shadowDistanceSetting.UpdatePreset();
                shadowSizeSettings.SetShadowResSize(1);
                shadowSizeSettings.SetShadowCascadeCount(0);
                shadowSizeSettings.UpdatePreset();
                graphicsSettings.SetAntiAliasing(2);
                graphicsSettings.SetAA_Mode(3);
                graphicsSettings.UpdatePreset();
                //other
                moreGraphicsSettings.SetLodBias(0);
                moreGraphicsSettings.SetsoftParticles(0);
                moreGraphicsSettings.UpdatePreset();
                gpui_GraphicsSettings.SetTreeDistance(0);
                gpui_GraphicsSettings.SetGrassDistance(0);
                gpui_GraphicsSettings.UpdatePreset();
                postProcessingSettings.SetMotionBlur(1);
                postProcessingSettings.SetCamDistance(0);
                postProcessingSettings.UpdatePreset();
                done = true;
            }
        }
        //high
        if (index == 2)
        {
            if (done == false)
            {
                //textures
                settingsObj.SetActive(false);
                textureSizeSettings.SetTextureSize(1);
                textureSizeSettings.UpdatePreset();
                //shadows
                shadowDistanceSetting.SetShadowDistance(1);
                shadowDistanceSetting.UpdatePreset();
                shadowSizeSettings.SetShadowResSize(2);
                shadowSizeSettings.SetShadowCascadeCount(0);
                shadowSizeSettings.UpdatePreset();
                graphicsSettings.SetAntiAliasing(2);
                graphicsSettings.SetAA_Mode(1);
                graphicsSettings.UpdatePreset();
                //other
                moreGraphicsSettings.SetLodBias(1);
                moreGraphicsSettings.SetsoftParticles(0);
                moreGraphicsSettings.UpdatePreset();
                gpui_GraphicsSettings.SetTreeDistance(1);
                gpui_GraphicsSettings.SetGrassDistance(1);
                gpui_GraphicsSettings.UpdatePreset();
                postProcessingSettings.SetMotionBlur(1);
                postProcessingSettings.SetCamDistance(1);
                postProcessingSettings.UpdatePreset();
                done = true;
            }
        }
        //med
        if (index == 3)
        {
            if (done == false)
            {
                //textures
                settingsObj.SetActive(false);
                textureSizeSettings.SetTextureSize(2);
                textureSizeSettings.UpdatePreset();
                //shadows
                shadowDistanceSetting.SetShadowDistance(2);
                shadowDistanceSetting.UpdatePreset();
                shadowSizeSettings.SetShadowResSize(2);
                shadowSizeSettings.SetShadowCascadeCount(1);
                shadowSizeSettings.UpdatePreset();
                graphicsSettings.SetAntiAliasing(1);
                graphicsSettings.SetAA_Mode(1);
                graphicsSettings.UpdatePreset();
                //other
                moreGraphicsSettings.SetLodBias(2);
                moreGraphicsSettings.SetsoftParticles(0);
                moreGraphicsSettings.UpdatePreset();
                gpui_GraphicsSettings.SetTreeDistance(2);
                gpui_GraphicsSettings.SetGrassDistance(2);
                gpui_GraphicsSettings.UpdatePreset();
                postProcessingSettings.SetMotionBlur(1);
                postProcessingSettings.SetCamDistance(2);
                postProcessingSettings.UpdatePreset();
                done = true;
            }
        }
        //low
        if (index == 4)
        {
            if (done == false)
            {
                //textures
                settingsObj.SetActive(false);
                textureSizeSettings.SetTextureSize(3);
                textureSizeSettings.UpdatePreset();
                //shadows
                shadowDistanceSetting.SetShadowDistance(3);
                shadowDistanceSetting.UpdatePreset();
                shadowSizeSettings.SetShadowResSize(3);
                shadowSizeSettings.SetShadowCascadeCount(2);
                shadowSizeSettings.UpdatePreset();
                graphicsSettings.SetAntiAliasing(0);
                graphicsSettings.SetAA_Mode(1);
                graphicsSettings.UpdatePreset();
                //other
                moreGraphicsSettings.SetLodBias(3);
                moreGraphicsSettings.SetsoftParticles(1);
                moreGraphicsSettings.UpdatePreset();
                gpui_GraphicsSettings.SetTreeDistance(3);
                gpui_GraphicsSettings.SetGrassDistance(3);
                gpui_GraphicsSettings.UpdatePreset();
                postProcessingSettings.SetMotionBlur(0);
                postProcessingSettings.SetCamDistance(3);
                postProcessingSettings.UpdatePreset();
                done = true;
            }
        }
        //very low
        if (index == 5)
        {
            if (done == false)
            {
                //textures
                settingsObj.SetActive(false);
                textureSizeSettings.SetTextureSize(4);
                textureSizeSettings.UpdatePreset();
                //shadows
                shadowDistanceSetting.SetShadowDistance(4);
                shadowDistanceSetting.UpdatePreset();
                shadowSizeSettings.SetShadowResSize(3);
                shadowSizeSettings.SetShadowCascadeCount(2);
                shadowSizeSettings.UpdatePreset();
                graphicsSettings.SetAntiAliasing(0);
                graphicsSettings.SetAA_Mode(0);
                graphicsSettings.UpdatePreset();
                //other
                moreGraphicsSettings.SetLodBias(4);
                moreGraphicsSettings.SetsoftParticles(1);
                moreGraphicsSettings.UpdatePreset();
                gpui_GraphicsSettings.SetTreeDistance(4);
                gpui_GraphicsSettings.SetGrassDistance(4);
                gpui_GraphicsSettings.UpdatePreset();
                postProcessingSettings.SetMotionBlur(0);
                postProcessingSettings.SetCamDistance(4);
                postProcessingSettings.UpdatePreset();
                done = true;
            }
        }
    }

}
