using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMainMenuScene : MonoBehaviour
{
    AudioSource ass;

    private void Start()
    {
        ass = GetComponent<AudioSource>();
        ass.Play();
    }
}
