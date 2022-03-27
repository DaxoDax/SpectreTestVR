using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

    /// <summary>
    /// This script is for playing the button click sound when it's pressed
    /// </summary>
   public  AudioSource ass;
   public void PlaySound()
    {
      if(!ass.isPlaying)
        {
            ass.Play();
        }
    }
}
