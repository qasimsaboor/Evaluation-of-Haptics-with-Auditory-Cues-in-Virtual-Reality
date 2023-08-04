using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SG;

public class Vibration : MonoBehaviour
{
    /// <summary> The Interactable object that we will be sending vibration commands to. </summary>
    /// <remarks> Since SG_Grabable derives from SG_Interactable, this will work for grabables, as well as any other script that derives from SG_Interactable. </remarks>
    public SG_Interactable objectToVibrate;

    /// <summary> The amplitude of the vibration. 0 = no vibration, 100 = full vibration. </summary>
    [Range(0, 100)] public int magnitude = 100;

    /// <summary> To which fingers the vibration command will be sent. 0 = thumb, 4 = pinky. </summary>
    public bool[] fingers = new bool[5] { true, true, false, false, false };

    /// <summary> The vibration command to be send. Cached so we do not need to regenerate it every frame. </summary>
    protected SGCore.Haptics.SG_TimedBuzzCmd vibrationCmd;


    // Use this for initialization
    void Start()
    {
        //regenerate the vibration command. We'll make it 0.02f (20ms) long so there will be overlap between two frames for a continuous vibration.
        vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(fingers, magnitude), 0.02f);
    }

    // Update is called once per frame
    void Update()
    {
        objectToVibrate.SendCmd(vibrationCmd); //SG_Interactable has SendCmd(..) functions that pass haptic commands to whatever is holding it.
    }

    // Runs when any of this script's variables are changed in the inspector, but only in the Editor.
    void OnValidate()
    {
        vibrationCmd = new SGCore.Haptics.SG_TimedBuzzCmd(new SGCore.Haptics.SG_BuzzCmd(fingers, magnitude), 0.02f); //regenerate the vibration command
    }
}