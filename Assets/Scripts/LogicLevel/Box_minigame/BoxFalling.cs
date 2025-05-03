using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxFalling : MonoBehaviour
{
    public GameObject BoxDot;
    public string scene;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            other.transform.position = BoxDot.transform.position;
            other.transform.rotation = BoxDot.transform.rotation;
        }
    }

   
}
