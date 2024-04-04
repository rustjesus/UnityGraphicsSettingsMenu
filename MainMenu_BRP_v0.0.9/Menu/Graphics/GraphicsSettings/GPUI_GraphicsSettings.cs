using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPUI_GraphicsSettings : MonoBehaviour
{
    [Header("To copy settings copy: GPUInstancerTreeManager.cs, GPUInstancerDetailManager.cs, & GPUInstancerDetailManagerEditor.cs")]
    public TMPro.TMP_Dropdown grassDistanceDropDown;
    public TMPro.TMP_Dropdown treeDistanceDropDown;
    void Start()
    {
        int val = PlayerPrefs.GetInt("Grass_Distance");
        grassDistanceDropDown.value = val;

        int val2 = PlayerPrefs.GetInt("Tree_Distance");
        treeDistanceDropDown.value = val2;
    }

    public void SetGrassDistance(int index)
    {
        PlayerPrefs.SetInt("Grass_Distance", index);

    }
    public void SetTreeDistance(int index)
    {
        PlayerPrefs.SetInt("Tree_Distance", index);
    }

    public void UpdatePreset()
    {
        //allows to change after preset swap
        int val = PlayerPrefs.GetInt("Grass_Distance");
        grassDistanceDropDown.value = val;

        //allows to change after preset swap
        int val2 = PlayerPrefs.GetInt("Tree_Distance");
        treeDistanceDropDown.value = val2;


    }
}
