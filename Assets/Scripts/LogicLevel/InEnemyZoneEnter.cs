using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InEnemyZoneEnter : MonoBehaviour
{
    public bool IsOff = false;
    public string scene;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Player") && (IsOff == false)))
        {
            SceneManager.LoadScene(scene);
        } 
    }
    public void IsOffTrue() 
    {
        IsOff = true;
    }

}
