using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    bool hit;

    void Update()
    {
        Vector3 origin = GameObject.Find("Player").transform.position;
        hit = Physics.Raycast(origin, transform.forward, 1.5f, 1);
        if (hit)
        {
            Debug.Log("Safe!");
        }

        RaycastHit outhit;
        hit = Physics.Raycast(origin, transform.forward,out outhit, 1.5f, ~8);
        Debug.DrawRay(origin, transform.forward * 1.5f, Color.blue);
        if (hit)
        {
            Debug.LogWarning("Not safe!");
            //Debug.Log(outhit.transform.name);
        }
    }
}
