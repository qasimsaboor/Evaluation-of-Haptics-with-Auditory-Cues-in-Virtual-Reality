using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ButtonPhysics : MonoBehaviour
{
    public UnityEvent onPressed;
    public UnityEvent onReleased;
    public Rigidbody buttonTopRigid;
    public Transform buttonTopPart;
    public Transform buttonLowerLimit;
    public Transform buttonUpperLimit;
    public AudioSource pressSound;
    public AudioSource releaseSound;
    public float threshold;
    public float force = 10;
    private float upperLowerDifference;
    public bool buttonIsPressed;
    private bool previousPressedState;
    public Collider[] CollidersToIgnore;

    void Start()
    {
        Collider localCollider = GetComponent<Collider>();
        if (localCollider != null)
        {
            Physics.IgnoreCollision(localCollider, buttonTopPart.GetComponentInChildren<Collider>());

            foreach (Collider singleCollider in CollidersToIgnore)
            {
                Physics.IgnoreCollision(localCollider, singleCollider);
            }
        }

        if (transform.eulerAngles != Vector3.zero)
        {
            Vector3 savedAngle = transform.eulerAngles;
            transform.eulerAngles = Vector3.zero;
            upperLowerDifference = buttonUpperLimit.position.y - buttonLowerLimit.position.y;
            transform.eulerAngles = savedAngle;
        }
        else
            upperLowerDifference = buttonUpperLimit.position.y - buttonLowerLimit.position.y;
    }

    void Update()
    {
        buttonTopPart.transform.localPosition = new Vector3(0, buttonTopPart.transform.localPosition.y, 0);
        buttonTopPart.transform.localEulerAngles = new Vector3(0, 0, 0);
        if (buttonTopPart.localPosition.y >= 0)
            buttonTopPart.transform.position = new Vector3(buttonUpperLimit.position.x, buttonUpperLimit.position.y, buttonUpperLimit.position.z);
        else
            buttonTopRigid.AddForce(buttonTopPart.transform.up * force * Time.deltaTime);

        if (buttonTopPart.localPosition.y <= buttonLowerLimit.localPosition.y)
            buttonTopPart.transform.position = new Vector3(buttonLowerLimit.position.x, buttonLowerLimit.position.y, buttonLowerLimit.position.z);


        if (Vector3.Distance(buttonTopPart.position, buttonLowerLimit.position) < upperLowerDifference * threshold)
            buttonIsPressed = true;
        else
            buttonIsPressed = false;

        if (buttonIsPressed && previousPressedState != buttonIsPressed)
            Pressed();
        if (!buttonIsPressed && previousPressedState != buttonIsPressed)
            Released();
    }

    void Pressed()
    {
        previousPressedState = buttonIsPressed;
        pressSound.pitch = 1;
        pressSound.Play();
        onPressed.Invoke();
    }

    void Released()
    {
        previousPressedState = buttonIsPressed;
        releaseSound.pitch = Random.Range(1.1f, 1.2f);
        releaseSound.Play();
        onReleased.Invoke();
    }
}