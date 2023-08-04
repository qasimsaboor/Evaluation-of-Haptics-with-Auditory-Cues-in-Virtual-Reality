using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : MonoBehaviour
{
    public GameObject OnionSeeds;
    public GameObject TomatoSeeds;
    public GameObject CucmberSeeds;
    public GameObject CarrotSeeds;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "onion")
        {
            OnionSeeds.SetActive(true);
        }
        if (other.gameObject.tag == "TomatoSeedsBag")
        {
            TomatoSeeds.SetActive(true);
        }
        if (other.gameObject.tag == "CarrotSeedsBag")
        {
            CarrotSeeds.SetActive(true);
        }
        if (other.gameObject.tag == "CucumberSeedsBag")
        {
            CucmberSeeds.SetActive(true);
        }
    }
}
