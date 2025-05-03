using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmaster : MonoBehaviour
{
    public AudioClip[] sound;
    private AudioSource audSrs => GetComponent<AudioSource>();
    public void PlaySound(AudioClip clip, float volume = 1f, bool destroyed = false, float p1 = 0.85f, float p2 = 1.2f)
    {
        audSrs.pitch = Random.Range(p1, p2);
        audSrs.PlayOneShot(clip, volume);
    }
}
