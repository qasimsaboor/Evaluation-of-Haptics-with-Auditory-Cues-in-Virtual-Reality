using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1Script : MonoBehaviour
{
    public TaskTimer stop;
    public GameObject tick;
    public GameObject brokenPot;
    public GameObject arrow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pumpkin"))
        {
            tick.SetActive(true);
            stop.StopTimer();
            arrow.SetActive(true);
        }
    }
}
