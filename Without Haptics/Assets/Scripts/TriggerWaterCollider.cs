using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWaterCollider : MonoBehaviour
{
    public GameObject Water;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WaterCan")
            Water.GetComponent<Collider>().enabled = true;
    }
}
