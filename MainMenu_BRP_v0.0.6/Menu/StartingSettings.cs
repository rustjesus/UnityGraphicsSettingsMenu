using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingSettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        AudioListener.pause = false;
    }


}
