using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant_Growth : MonoBehaviour
{
    private int currentProgress = 0;
    public int timeBetweenGrowths;
    public int maxPlantGrowth;
    public GameObject Tomato;
    public GameObject Onion;
    public GameObject Cucumber;
    public GameObject Carrot;
    void Start()
    {
        InvokeRepeating("Growth", timeBetweenGrowths, timeBetweenGrowths);
    }
    private void Growth()
    {       
        if (currentProgress != maxPlantGrowth)
        {
            gameObject.transform.GetChild(currentProgress).gameObject.SetActive(true);
        }
        if (currentProgress > 0 && currentProgress < maxPlantGrowth)
        {
            gameObject.transform.GetChild(currentProgress - 1).gameObject.SetActive(false);
        }
        if (currentProgress < maxPlantGrowth)
        {
            currentProgress++;
        }
        Carrot.SetActive(false);
        Onion.SetActive(false);
        Cucumber.SetActive(false);
        Tomato.SetActive(false);
    }
    
}
