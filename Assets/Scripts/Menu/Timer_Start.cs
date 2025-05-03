using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer_Start : MonoBehaviour
{
    [SerializeField] float Timeremain;
    public GameObject StartText;
    public bool NextScene = false;
    public string scene;
    
    void Update()
    {
        if (Timeremain > 0)
        {
            Timeremain -= Time.deltaTime;
        }
        else if (Timeremain < 0)
        {
            Timeremain = 0;
            this.ChangeScene(); //if timer = 0, sound end
        }
        int minutes = Mathf.FloorToInt(Timeremain / 60);
        int seconds = Mathf.FloorToInt(Timeremain % 60);
    }

    public void ChangeScene() 
    {
        if (NextScene == false) 
        { 
            StartText.SetActive(true); 
        }
        if (NextScene == true)
        {
            SceneManager.LoadScene(scene);
        }

    }
}
