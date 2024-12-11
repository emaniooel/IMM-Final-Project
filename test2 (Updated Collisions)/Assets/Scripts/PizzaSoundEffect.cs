using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaSoundEffect : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        //If space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ///play the sound effect
            PlaySound();
        }
    }

    public void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}