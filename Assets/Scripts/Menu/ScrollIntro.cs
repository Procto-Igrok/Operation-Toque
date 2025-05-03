using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollIntro : Soundmaster
{
    public GameObject PrevPic;
    public GameObject NextPic;

    public void OnScrolButDown() 
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter)) 
        {
            PrevPic.SetActive(false);
            NextPic.SetActive(true);
            PlaySound(sound[0]);
            Debug.Log("Клик!");
        }
    }

}
