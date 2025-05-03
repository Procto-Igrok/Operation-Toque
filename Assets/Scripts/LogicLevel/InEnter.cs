using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InEnter : MonoBehaviour
{
    public GameObject TpDot;
    public bool isLoadNewScene;
    public bool LoadScene = false;
    public string scene;
    [SerializeField] float remainingTime;
    [SerializeField] float remainingTime1;
    public bool MusicOn = false;
    public AudioSource mus;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            other.transform.position = TpDot.transform.position;
            if (isLoadNewScene == true) 
            {
                LoadScene = true;
               
            }
            if (MusicOn == true) 
            {
                mus.Play();
            }
        }
        
    }

    public void Update() 
    {
        if (LoadScene == true)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else if (remainingTime < 0)
            {
                remainingTime = 0;
                this.NextScene(); //if timer = 0, game closed
            }
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
        }if (isLoadNewScene == true)
        {
            if (remainingTime1 > 0)
            {
                remainingTime1 -= Time.deltaTime;
            }
            else if (remainingTime1 < 0)
            {
                remainingTime1 = 0;
                this.NextScene(); //if timer = 0, game closed
            }
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadSCene() 
    {
        isLoadNewScene = true;
    }

}
