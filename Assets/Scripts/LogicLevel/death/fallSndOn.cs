using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallSndOn : MonoBehaviour
{
    public Collider2D me;
    public AudioSource aud;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") 
        {
            aud.Play();
        }
    }
}
