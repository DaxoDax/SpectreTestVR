using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillTopTrigger : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bolt")
        {
            rb.isKinematic = false;
        }

       
    }


    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Bolt")
        {
            rb.isKinematic = true;
        }
    }
}
