using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMinigame : MonoBehaviour
{
    public GameObject Door1;
    public GameObject Door2;
    public bool isOff = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            if (isOff == true)
            {
                Door1.SetActive(false);
                Door2.SetActive(false);
            }
            if (isOff == false)
            {
                Door1.SetActive(true);
                Door2.SetActive(true);
            }
        }
    }
}
