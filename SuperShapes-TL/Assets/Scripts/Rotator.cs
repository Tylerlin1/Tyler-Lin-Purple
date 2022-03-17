using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 30f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Rotate the object on the x axis
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
    }
}
