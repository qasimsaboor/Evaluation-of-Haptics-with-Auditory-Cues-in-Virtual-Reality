using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPour : MonoBehaviour
{
    public ParticleSystem Event;
    public GameObject OnionGrowth;
    public GameObject CucumberGrowth;
    public GameObject CarrotGrowth;
    public GameObject TomatoGrowth;
    public GameObject Onion;
    public GameObject Cucumber;
    public GameObject Carrot;
    public GameObject Tomato;
    public GameObject tick;
    public TaskTimer stop;
    public GameObject arrow;
    public GameObject taskArrow;
    public AudioSource wateringAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlantGrowth")
        {
            Event.Play();
            wateringAudio.Play();
            if (Onion.activeSelf)
            {
                OnionGrowth.SetActive(true);
                tick.SetActive(true);
                stop.StopTimer();
                arrow.SetActive(false);
                taskArrow.SetActive(true);
            }
            if (Tomato.activeSelf)
            {
                TomatoGrowth.SetActive(true);
                tick.SetActive(true);
                stop.StopTimer();
                arrow.SetActive(false);
                taskArrow.SetActive(true);
            }
            if (Cucumber.activeSelf)
            {
                CucumberGrowth.SetActive(true);
                tick.SetActive(true);
                stop.StopTimer();
                arrow.SetActive(false);
                taskArrow.SetActive(true);
            }
            if (Carrot.activeSelf)
            {
                CarrotGrowth.SetActive(true);
                tick.SetActive(true);
                stop.StopTimer();
                arrow.SetActive(false);
                taskArrow.SetActive(true);
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PlantGrowth")
        {
            Event.Stop();
            wateringAudio.Stop();
        }
    }
}
