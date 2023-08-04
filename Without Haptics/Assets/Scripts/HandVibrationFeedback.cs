using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SG;

public class HandVibrationFeedback : MonoBehaviour
{
    public SG_Interactable objectToVibrate;
    [Range(0, 100)] public int magnitude = 100;
    public bool[] Indexfinger = new bool[5] { true, true, false, false, false };
    public bool[] Middlefinger = new bool[5] { true, false, true, false, false };
    public bool[] Ringfinger = new bool[5] { true, false, false, true, false };
    public bool[] Pinkyfinger = new bool[5] { true, false, false, false, true };
    public bool[] LIndexfinger = new bool[5] { true, true, false, false, false };
    public bool[] LMiddlefinger = new bool[5] { true, false, true, false, false };
    public bool[] LRingfinger = new bool[5] { true, false, false, true, false };
    public bool[] LPinkyfinger = new bool[5] { true, false, false, false, true };
    protected SGCore.Haptics.SG_TimedBuzzCmd vibrationCmd;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Index")
        {
            vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(Indexfinger, magnitude), 1f);
            objectToVibrate.SendCmd(vibrationCmd);
            Debug.Log("vibration sent index");
        }
        if (other.gameObject.tag == "Middle")
        {
            vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(Middlefinger, magnitude), 1f);
            objectToVibrate.SendCmd(vibrationCmd);
            Debug.Log("vibration sent middle");
        }
        if (other.gameObject.tag == "Ring")
        {
            vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(Ringfinger, magnitude), 1f);
            objectToVibrate.SendCmd(vibrationCmd);
            Debug.Log("vibration sent ring");
        }
        if (other.gameObject.tag == "Pinky")
        {
            vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(Pinkyfinger, magnitude), 1f);
            objectToVibrate.SendCmd(vibrationCmd);
            Debug.Log("vibration sent pinky");
        }
        if (other.gameObject.tag == "LeftIndex")
        {
            vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(LIndexfinger, magnitude), 1f);
            objectToVibrate.SendCmd(vibrationCmd);
            Debug.Log("vibration sent left index");
        }
        if (other.gameObject.tag == "LeftMiddle")
        {
            vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(LMiddlefinger, magnitude), 1f);
            objectToVibrate.SendCmd(vibrationCmd);
            Debug.Log("vibration sent left middle");
        }
        if (other.gameObject.tag == "LeftRing")
        {
            vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(LRingfinger, magnitude), 1f);
            objectToVibrate.SendCmd(vibrationCmd);
            Debug.Log("vibration sent left ring");
        }
        if (other.gameObject.tag == "LeftPinky")
        {
            vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(LPinkyfinger, magnitude), 1f);
            objectToVibrate.SendCmd(vibrationCmd);
            Debug.Log("vibration sent left pinky");
        }
    }
}