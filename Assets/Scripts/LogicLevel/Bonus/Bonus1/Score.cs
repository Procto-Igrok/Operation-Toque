using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    public GameObject[] lamps;
    public GameObject corLamp;
    public TextMeshPro text;
    public SpriteRenderer spr;
    public Sprite[] scrSpr;

    public void Update()
    {
        lamps = GameObject.FindGameObjectsWithTag("Wrong");
        corLamp = GameObject.FindGameObjectWithTag("Correct");
        text.text = score.ToString();
    }
    public void OnAnswerCorrect()
    {
        score += 1;
        Destroy(corLamp);
        foreach (GameObject lamp in lamps)
        {
           
            Destroy(lamp);
        
        }
    }
    public void OnAnswerWrong()
    {
     
        Destroy(corLamp);
        foreach (GameObject lamp in lamps)
        {

            Destroy(lamp);

        }
    }
    public void Result() 
    {
        if (score <= 4) 
        {
            spr.sprite = scrSpr[0];
            Debug.Log("bad");
        }
        if (score >= 5 & score <= 17) 
        {
            spr.sprite = scrSpr[1];
            Debug.Log("normal");
        }
        if (score >= 18 & score <= 20) 
        {
            spr.sprite = scrSpr[2];
            Debug.Log("good");
        }
    
    }

}
