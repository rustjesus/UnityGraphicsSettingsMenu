using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeQualitySettings : MonoBehaviour
{
    [SerializeField] private Dropdown qualityDropdown;

    public void SetQualityLevelDrop(int index)
    {
        QualitySettings.SetQualityLevel(index, false);
    }

    public void Settings()
    {
        //Pixel Light Count 
        //Int Value 
        //Upto 4
        QualitySettings.pixelLightCount = 4;

        //Texture Quality
        //Int Value
        //Full Res - 0, Half Res - 1, Quarter Res - 2, Eighth Res - 3
        QualitySettings.globalTextureMipmapLimit = 0;

        //Anisotropic Textures
        //Enum
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.ForceEnable;
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.Disable;
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.Enable;

        //Anti aliasing
        //Int Value
        //Disabled - 0, 2x - 1, 4x - 2, 8x - 3
        QualitySettings.antiAliasing = 1;

        //Soft Particles
        //Bool
        QualitySettings.softParticles = false;
        QualitySettings.softParticles = true;

        //Realtime Reflection Probes
        //Bool
        QualitySettings.realtimeReflectionProbes = false;
        QualitySettings.realtimeReflectionProbes = true;

        //Billboards Face Camera position
        //Bool
        QualitySettings.billboardsFaceCameraPosition = false;
        QualitySettings.billboardsFaceCameraPosition = true;

        //Resoultion Scaling Fixed DPI Factor
        //Float Value
        //Maximum of 1
        QualitySettings.resolutionScalingFixedDPIFactor = 1;

        //Texture Streaming
        //Bool
        QualitySettings.streamingMipmapsActive = false;
        QualitySettings.streamingMipmapsActive = true;

        //Shadowmask Mode
        //Enum
        QualitySettings.shadowmaskMode = ShadowmaskMode.Shadowmask;
        QualitySettings.shadowmaskMode = ShadowmaskMode.DistanceShadowmask;

        //Shadows
        //Enum
        QualitySettings.shadows = ShadowQuality.Disable;
        QualitySettings.shadows = ShadowQuality.HardOnly;
        QualitySettings.shadows = ShadowQuality.All; //(Same as Hard and Soft Shadows)

        //Shadow Resolution
        //Enum
        QualitySettings.shadowResolution = ShadowResolution.Low;
        QualitySettings.shadowResolution = ShadowResolution.Medium;
        QualitySettings.shadowResolution = ShadowResolution.High;
        QualitySettings.shadowResolution = ShadowResolution.VeryHigh;

        //Shadow Projection
        //Enum
        QualitySettings.shadowProjection = ShadowProjection.CloseFit;
        QualitySettings.shadowProjection = ShadowProjection.StableFit;

        //Shadow Distance
        //Float Value
        QualitySettings.shadowDistance = 150;

        //Shadow Near Plane Offset
        //Float Value
        QualitySettings.shadowNearPlaneOffset = 3;

        // Shadow Cascades
        //Int Value
        //No Cascades (0), Two Cascades (1), Four Cascades (2)
        QualitySettings.shadowCascades = 2;

        //Skin Weights
        //Enum
        QualitySettings.skinWeights = SkinWeights.OneBone;
        QualitySettings.skinWeights = SkinWeights.TwoBones;
        QualitySettings.skinWeights = SkinWeights.FourBones;
        QualitySettings.skinWeights = SkinWeights.Unlimited;

        //VSync Count
        //Int Value
        //Dont Sync (0), Every V Blank (1), Every Second V Blank (2)
        QualitySettings.vSyncCount = 0;

        //LOD Bias
        //Float Value
        QualitySettings.lodBias = 2;

        //Maximum LOD level
        //Int Value
        QualitySettings.maximumLODLevel = 0;

        //Particle Raycast Budget
        //Int Value
        QualitySettings.particleRaycastBudget = 4096;

        //Async Upload time slice
        //Int Value
        QualitySettings.asyncUploadTimeSlice = 2;

        //Async Upload buffer size
        //Int Value
        QualitySettings.asyncUploadBufferSize = 16;

        //Async Upload Persistent Buffer
        //Bool
        QualitySettings.asyncUploadPersistentBuffer = false;
        QualitySettings.asyncUploadPersistentBuffer = true;
    }
}
