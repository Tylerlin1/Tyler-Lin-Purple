using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxFeatures : MonoBehaviour
{
    public float rotationSpeed = 30f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Rotate the object on the x axis
        transform.Rotate(new Vector3(1, 0, 1), Time.deltaTime * rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
