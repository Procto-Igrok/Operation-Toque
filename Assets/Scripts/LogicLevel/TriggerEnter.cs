using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{
    public GameObject But;
    public GameObject But1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        But.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        But.SetActive(false);
        But1.SetActive(false);
    }
}
