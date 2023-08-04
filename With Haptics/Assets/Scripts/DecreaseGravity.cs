using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaseGravity : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component of the current game object
        rb = GetComponent<Rigidbody>();

        // Set the desired gravity for the specific Rigidbody
        rb.useGravity = false; // Disable the default gravity
        rb.AddForce(Vector3.down * 12f); // Apply a custom downward force
    }

    // Update is called once per frame
    void Update()
    {
        // Custom gravity control logic can be implemented here, if needed
    }
}
