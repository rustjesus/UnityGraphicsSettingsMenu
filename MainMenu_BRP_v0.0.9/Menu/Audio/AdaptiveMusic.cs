using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptiveMusic : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip[] musicClips;

    private int currentClipIndex = 0;

    void Start()
    {
        audioSource.clip = musicClips[currentClipIndex];
        audioSource.Play();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            currentClipIndex++;

            if (currentClipIndex >= musicClips.Length)
            {
                currentClipIndex = 0;
            }

            audioSource.clip = musicClips[currentClipIndex];
            audioSource.Play();
        }
    }
}