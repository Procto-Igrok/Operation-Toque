using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Level : MonoBehaviour
{
    public string scene;

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) 
        {
            SceneManager.LoadScene(scene); 
        }
    }
}
