using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool ImCorrect;
    public bool ImWrong;

    public Score sc;
    public RandomLapm spn;

    public void OnMouseDown()
    {
        RandomLapm spn = FindObjectOfType<RandomLapm>();
        Score sc = FindObjectOfType<Score>();
        if (ImCorrect == true) 
        {
            sc.OnAnswerCorrect();
            spn.OnAnswChoose();
            Debug.Log("Correct");
        }
        if (ImWrong == true) 
        {
            sc.OnAnswerWrong();
            spn.OnAnswChoose();
            Debug.Log("Wrong");
        }
    }
}
