using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsOn : MonoBehaviour
{
    public AudioSource aud;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            aud.Play();
        }   
    }
}
