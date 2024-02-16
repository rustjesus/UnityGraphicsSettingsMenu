using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetVolume : MonoBehaviour
{

    [SerializeField] private AudioMixer masterMixer;
    public Slider masterSlider;
    public Slider sfxSlider;
    public Slider musicSlider;
    private void Start()
    {
        //gets volume on start
        //masterSlider.value = PlayerPrefs.GetFloat("MasterVolume");

        if (PlayerPrefs.GetInt("FirstVolumeLoad") == 0)
        {
            PlayerPrefs.SetFloat("MusicVolume", 1f);
            PlayerPrefs.SetFloat("SfxVolume", 1f);
            PlayerPrefs.SetFloat("MasterVolume", 1f);

            PlayerPrefs.SetInt("FirstVolumeLoad", 1);
        }

        masterSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("SfxVolume");
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }
    public void SetMasterVolume(float sliderValue)
    {
        masterMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MasterVolume", sliderValue);
        PlayerPrefs.Save();

    }
    public void SetSFXLevelSlider(float sliderValue)
    {
        masterMixer.SetFloat("SfxVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("SfxVolume", sliderValue);
        PlayerPrefs.Save();

    }
    public void SetMusicLevelSlider(float sliderValue)
    {
        masterMixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
        PlayerPrefs.Save();
    }


    public void DeletePrefs()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();

    }

}
