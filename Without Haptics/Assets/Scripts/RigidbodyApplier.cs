using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyApplier : MonoBehaviour
{
    public GameObject objectWithRigidBody; // Reference to the object you want to apply the rigid body to
    private Rigidbody objectRigidbody;
    private Vector3 initialPosition;

    private void Start()
    {
        objectRigidbody = objectWithRigidBody.GetComponent<Rigidbody>();
        objectRigidbody.isKinematic = true; // Initially set the rigid body to be kinematic (not affected by physics)
        initialPosition = objectWithRigidBody.transform.position; // Save the initial position of the object
    }

    public void ApplyRigidBody()
    {
        objectRigidbody.isKinematic = false; // Enable the rigid body to be affected by physics
        //objectWithRigidBody.transform.position = initialPosition; // Reset the position of the object
    }
}