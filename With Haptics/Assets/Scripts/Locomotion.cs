using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Locomotion : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] GameObject rightHand, leftHand;
    public float characterSpeed = 12;
    public float threshold = 0.02f;
    Vector3 prevPositionLeft, prevPositionRight, directionToMove;
    Vector3 defaultGravity = new Vector3(0, -9.8f, 0);

    void Start()
    {
        characterController = FindObjectOfType<CharacterController>();
        setPrevPosition();
    }

    void Update()
    {
        Vector3 velocityLeftHand = leftHand.transform.position - prevPositionLeft;
        Vector3 velocityRightHand = rightHand.transform.position - prevPositionRight;
        float totalvelocity = +velocityLeftHand.magnitude * 0.8f + velocityRightHand.magnitude * 0.8f;

        if (totalvelocity >= threshold)
        {
            directionToMove = Camera.main.transform.forward;
            characterController.Move(characterSpeed * Time.deltaTime * Vector3.ProjectOnPlane(directionToMove, Vector3.up));
        }
        characterController.Move(defaultGravity * Time.deltaTime);
        setPrevPosition();
    }

    void setPrevPosition()
    {
        prevPositionLeft = leftHand.transform.position;
        prevPositionRight = rightHand.transform.position;
    }
}