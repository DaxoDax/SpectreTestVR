using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpInstructions : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelTwo;
    public GameObject drill;
    public bool isItCOnnected;
    Animator anim;

    public AudioSource ass;
    public AudioClip popUpClip;
  
    public float time = 4;

    private void Start()
    {
        anim = panel.GetComponent<Animator>();
        
    }

    private void Update()
    {
        isItCOnnected = drill.GetComponent<SnapToLocation>().plugedIn;
        if(isItCOnnected == true)
        {
            panelTwo.SetActive(true);
            Invoke("PanelTwoFadeOut", 6f);
            Sound();
            Invoke("SoundEnd", 0.5f);
            Invoke("Death", 6.5f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            anim.SetBool("FadeIn", true);
            Sound();
            Invoke("PanelFadeOut", time);
        }
    }


    public void PanelFadeOut()
    {
        anim.SetBool("FadeIn", false);
    }

    public void PanelTwoFadeOut()
    {
        panelTwo.SetActive(false);
    }

    public void Death()
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
