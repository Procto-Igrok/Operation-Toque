using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown_Timer : MonoBehaviour
{
     [SerializeField] float remainingTime;
    public GameObject obj;
    public Animator player;
    public Animator door;
    public string anim;

    public bool isHacking = false;
   
    void Update()
    {if(isHacking == true)
        { 
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else if (remainingTime < 0) 
            {
                remainingTime = 0;
                this.off(); //if timer = 0, game closed
            }
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);

            player.SetTrigger(anim);
        }
    }
    public void off()
    {
        door.SetBool("isOpen", true);
        isHacking = false;
    }

    public void Hacking()
    {
        isHacking = true;
    }
}

