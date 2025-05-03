using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMenu : MonoBehaviour
{
    public GameObject Screen1;
    public GameObject Screen2;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Screen1.SetActive(false);
            Screen2.SetActive(true);
        }
    }
}
