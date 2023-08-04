using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3Script : MonoBehaviour
{
    public GameObject OnionFinalStage;
    public GameObject CarrotFinalStage;
    public GameObject CucumberFinalStage;
    public GameObject TomatoFinalStage;
    public GameObject tick;
    public TaskTimer stop;

    // Update is called once per frame
    void Update()
    {
        if (OnionFinalStage.activeSelf || CarrotFinalStage.activeSelf || CucumberFinalStage.activeSelf || TomatoFinalStage.activeSelf)
        {
            Debug.Log("final stage reached");
        }
    }
}
