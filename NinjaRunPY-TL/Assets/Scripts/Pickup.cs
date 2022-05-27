using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public GameObject kk;
    // Start is called before the first frame update
    void Start()
    {
        //kk = GameObject.Find("door");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);

            Destroy(GameObject.Find("door"));
        }
    }
}
