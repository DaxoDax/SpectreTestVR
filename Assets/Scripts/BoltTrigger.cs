using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltTrigger : MonoBehaviour
{

   public  AudioSource ass;

    Rigidbody rb;
    public GameObject bolt;

    public GameObject panel;

    private void Start()
    {
        rb = bolt.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bolt")
        {
           
            if (!ass.isPlaying)
            {
                ass.Play();
            }
            rb.isKinematic = true;
            panel.SetActive(true);

        }
    }
   
}
