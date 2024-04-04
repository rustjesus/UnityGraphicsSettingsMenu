using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSvis : MonoBehaviour
{
    [SerializeField] private GameObject fpsObj;
    private float timer1 = 0f;
    private float updateInterval1 = 1f;
    void Start()
    {
        SetFPSVis();


    }
    private void Update()
    {
        // Increment the timer with the time passed since the last frame
        timer1 += Time.deltaTime;

        // Check if the timer has reached the desired interval
        if (timer1 >= updateInterval1)
        {
            SetFPSVis();
            // Reset the timer
            timer1 = 0f;
        }
    }
    private void SetFPSVis()
    {
        if (PlayerPrefs.GetInt("FPS_Counter_Mode") == 0)
        {
            fpsObj.SetActive(true);
        }
        if (PlayerPrefs.GetInt("FPS_Counter_Mode") == 1)
        {
            fpsObj.SetActive(false);
        }
    }
}
