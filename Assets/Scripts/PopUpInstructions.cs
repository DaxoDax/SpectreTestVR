using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpInstructions : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelTwo;
    public GameObject drill;

    public bool isItConnected;
    Animator anim;

    public AudioSource ass;
    public AudioClip popUpClip;
  
    public float time = 4;

    private void Start()
    {
        anim = panel.GetComponent<Animator>();  
    }


    /* if drill is connected with hose , panelTwo shows up and disappear after 6.5 seconds*/
    private void Update()
    {
        isItConnected = drill.GetComponent<SnapToLocation>().plugedIn;
        if(isItConnected == true)
        {
            //panel shows up
            panelTwo.SetActive(true);
            //prompt sound plays
            Sound();
            //prompt sound stops
            Invoke("SoundEnd", 0.5f);
            //panel disappear after determined time
            Invoke("PanelDisappear", 6.5f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //turning on animation
            anim.SetBool("FadeIn", true);
            Sound();
            // turning on fade out animation
            Invoke("PanelFadeOut", time);
        }
    }


    public void PanelFadeOut()
    {
        anim.SetBool("FadeIn", false);
    }

   

    public void PanelDisappear()
    {
        this.gameObject.SetActive(false);
    }

    public void Sound()
    {
        
        if(!ass.isPlaying)
        {
            ass.Play();
        }
        
    }

    public void SoundEnd()
    {
        ass = ass.GetComponent<AudioSource>();
        ass.enabled = false;
    }




}
