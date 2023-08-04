using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2Script : MonoBehaviour
{
    public GameObject tick;

    private bool hasShovel;
    private bool hasPitchFork;
    private bool hasRake;
    public TaskTimer stop;
    public GameObject arrow;
    public AudioSource shovelAudio;
    public AudioSource rakeAudio;

    private void Start()
    {
        hasShovel = false;
        hasPitchFork = false;
        hasRake = false;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shovel"))
        {
            hasShovel = true;
            shovelAudio.Play();
        }
        else if (other.CompareTag("PitchFork"))
        {
            hasPitchFork = true;
            shovelAudio.Play();
        }
        else if (other.CompareTag("Rake"))
        {
            hasRake = true;
            rakeAudio.Play();
        }

        if (hasShovel && hasPitchFork && hasRake)
        {
            tick.SetActive(true);
            stop.StopTimer();
            arrow.SetActive(true);
        }
    }
}