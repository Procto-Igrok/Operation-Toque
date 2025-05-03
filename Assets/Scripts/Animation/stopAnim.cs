using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopAnim : MonoBehaviour
{
    public string anName;
    public Animator Anim;
    public void StopAn()
    {
        Anim.enabled = false;
    }
    public void PlayAn()
    {
        Anim.enabled = true;
        Anim.Play(anName);
    }
    public void Click()
    {
        Debug.Log("Click!");
    }
}
