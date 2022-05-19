using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    bool hit;

    void Update()
    {
        hit = Physics.Raycast(transform.forward, Vector3.forward, 5f);
    }
}
