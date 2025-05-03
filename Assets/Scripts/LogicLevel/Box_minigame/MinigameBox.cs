using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameBox : MonoBehaviour
{
    public GameObject Door2;
    public GameObject plate;
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Box"))
        {
            Door2.SetActive(false);
            plate.SetActive(false);
        }
        else 
        {
            plate.SetActive(true);
        }
    }
}
