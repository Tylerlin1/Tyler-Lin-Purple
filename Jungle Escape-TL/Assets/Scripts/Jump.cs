using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rigidbody;

    float jumpForce = 5.7f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(rigidbody.velocity.y > -.01 && rigidbody.velocity.y < .01)
        {

        }
        if(Input.GetButtonDown("Jump")){
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

