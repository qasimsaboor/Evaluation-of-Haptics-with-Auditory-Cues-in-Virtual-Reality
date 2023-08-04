using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TaskTimer : MonoBehaviour
{
    public float timeValue = 0;
    public Text timerText;
    private bool timerStopped = false;

    // Update is called once per frame
    void Update()
    {
        if (!timerStopped)
        {
            timeValue += Time.deltaTime;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = (timeToDisplay % 1) * 100;

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }

    public void StopTimer()
    {
        timerStopped = true;
        DisplayStopTime(timeValue);
    }

    void DisplayStopTime(float stopTime)
    {
        float minutes = Mathf.FloorToInt(stopTime / 60);
        float seconds = Mathf.FloorToInt(stopTime % 60);
        float milliseconds = (stopTime % 1) * 100;

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }
}
