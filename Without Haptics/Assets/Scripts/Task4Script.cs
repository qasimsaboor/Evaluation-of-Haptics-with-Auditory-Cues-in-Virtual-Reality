using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Task4Script : MonoBehaviour
{
    private int tomatoCount = 0;
    private int grapeCount = 0;
    public GameObject tick;
    public GameObject clock;
    public TaskTimer stop;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tomato"))
        {
            tomatoCount++;
            Debug.Log("Tomato added! Current count: " + tomatoCount);
        }
        else if (other.CompareTag("Grapes"))
        {
            grapeCount++;
            Debug.Log("Grape added! Current count: " + grapeCount);
        }

        if (tomatoCount == 2 && grapeCount == 2)
        {
            //clock.SetActive(false);
            stop.StopTimer();
            tick.SetActive(true);
            Debug.Log("Won!");
        }
    }
}