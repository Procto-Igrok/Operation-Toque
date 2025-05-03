using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string scene;
    

    // Update is called once per frame
    public void LS() 
    {
        SceneManager.LoadScene(scene); 
    }

    public void QuitG()
    {
        Application.Quit();
    }
}
