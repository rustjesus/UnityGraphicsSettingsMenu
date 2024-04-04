using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Resolutions : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown resolutionDropdown;
    [SerializeField] private Toggle fullscreenToggle;
    [SerializeField] private Button exclusiveButton;
    private Resolution[] resolutions;

    private List<Resolution> filteredResolutions;
    // Get selected resolution
    private Resolution selectedResolution;
    //private float currentRefreshRate;
    private int currentResolutionIndex = 0;
    private void Start()
    {
        exclusiveButton.gameObject.SetActive(false);

        if (PlayerPrefs.GetInt("Fullscreen") == 1)
        {
            fullscreenToggle.isOn = true;
        }
        else
        {
            fullscreenToggle.isOn = false;
        }
        // Get available resolutions
        resolutions = Screen.resolutions;
        filteredResolutions = new List<Resolution>();

        // Clear dropdown options
        resolutionDropdown.ClearOptions();

        for (int i = 0; i < resolutions.Length; i++)
        {
            if (!filteredResolutions.Any(x => x.width == resolutions[i].width && x.height == resolutions[i].height))  //check if resolution already exists in list
            {
                filteredResolutions.Add(resolutions[i]);  //add resolution to list if it doesn't exist yet
            }
        }

        List<string> options = new List<string>();

        for (int i = 0; i < filteredResolutions.Count; i++)
        {
            string resolutionOption = filteredResolutions[i].width + " x " + filteredResolutions[i].height;
            options.Add(resolutionOption);
            if (filteredResolutions[i].width == Screen.width && filteredResolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        // Add options to the dropdown
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();

        //set to exclusive to fix lowest resolution bug with unity
        if(currentResolutionIndex == 0)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
    }

    public void ApplyResolution()
    {
        int resolutionIndex = resolutionDropdown.value;

        // Get selected resolution
        selectedResolution = filteredResolutions[resolutionIndex];


        // Set fullscreen mode based on the toggle value
        bool fullscreen = fullscreenToggle.isOn;

        // Save the fullscreen toggle state
        PlayerPrefs.SetInt("Fullscreen", fullscreen ? 1 : 0);
        PlayerPrefs.Save();

        // Apply the selected resolution and fullscreen mode
        Screen.SetResolution(selectedResolution.width, selectedResolution.height, fullscreen);
    }

    public void SetFullscreenMode(bool screenmode)
    {
        Screen.SetResolution(selectedResolution.width, selectedResolution.height, screenmode);
        // Set fullscreen mode based on the toggle value
        bool fullscreen = fullscreenToggle.isOn;

        // Save the fullscreen toggle state
        PlayerPrefs.SetInt("Fullscreen", fullscreen ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetExclusiveFullScreen()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
    }

    private void Update()
    {
        if (fullscreenToggle.isOn)
        {
            exclusiveButton.gameObject.SetActive(true);
        }
        else
        {
            exclusiveButton.gameObject.SetActive(false);
        }
    }
}