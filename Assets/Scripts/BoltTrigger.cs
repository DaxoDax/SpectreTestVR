using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltTrigger : MonoBehaviour
{

    public  AudioSource ass;
    public GameObject confetti;
    

    Rigidbody rb;
    public GameObject bolt;

    //panel that shows up when simulation is over
    public GameObject congratulationsPanel;

    private void Start()
    {
        rb = bolt.GetComponent<Rigidbody>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bolt")
        {
           //congratulation sound plays
            if (!ass.isPlaying)
            {
                ass.Play();
            }
            // when bolt is screwed is Kinematis becomes true so that bolt can't move anymore
            rb.isKinematic = true;

            //when bolt touches the trigger, congratulations panel shows up
            congratulationsPanel.SetActive(true);
            //turning on particle system
            confetti.GetComponent<ParticleSystem>().Play();

        }
    }
   
}
