using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSC : MonoBehaviour
{

    public float num;
    public GameObject trigger;
    public AudioSource audioSource;
    public AudioClip audioClip;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }


        
}