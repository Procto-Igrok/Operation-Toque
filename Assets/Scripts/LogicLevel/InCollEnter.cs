using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InCollEnter : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject me;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
