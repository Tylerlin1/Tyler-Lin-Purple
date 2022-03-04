﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Destruction Timer")]
    //After this time, the object will be destroyed
    public float timeToDestruction;
    // Start is called before the first frame update

    void Start()
    {
        //Execute function based on timeToDestruction
        Invoke("DestroyObject", timeToDestruction);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DestroyObject()
    {
        if(gameObject.name == "Cube"){

        } else
        {
            //Destroy Gameobject
            Destroy(gameObject);
        }
    }
}

