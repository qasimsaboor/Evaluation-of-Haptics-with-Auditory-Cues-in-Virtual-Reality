using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController : MonoBehaviour
{
    public ParticleSystem rainParticleSystem;
    public float minDelay = 10f; // Minimum delay before rain starts (in seconds)
    public float maxDelay = 30f; // Maximum delay before rain starts (in seconds)
    public float rainDuration = 10f; // Duration of rain (in seconds)
    public AudioSource RainSound;
    private bool isRainActive = false;

    private void Start()
    {
        // Start a timer to randomly activate rain
        float delay = Random.Range(minDelay, maxDelay);
        Invoke("ActivateRain", delay);
    }

    private void ActivateRain()
    {
        // Activate the rain particle system
        rainParticleSystem.Play();
        RainSound.Play();
        isRainActive = true;

        // Start a timer to turn off rain after the specified duration
        Invoke("DeactivateRain", rainDuration);
    }

    private void DeactivateRain()
    {
        // Deactivate the rain particle system
        rainParticleSystem.Stop();
        RainSound.Stop();
        isRainActive = false;
    }
}
