using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfIDNChoice : MonoBehaviour
{
    public GameObject corrLamp;
    public Score sc;
    public RandomLapm rnd;
    void Update()
    {
        corrLamp = GameObject.FindGameObjectWithTag("Correct");
       
    }

    public void OnButDown()
    {
        if (corrLamp != GameObject.FindGameObjectWithTag("Correct"))
        {
            //sc.OnAnswerCorrect();
            sc.OnAnswerWrong();
            rnd.OnAnswChoose();
            Debug.Log("Correct");
        }
        else
        {
            sc.OnAnswerCorrect();
            rnd.OnAnswChoose();
            //sc.OnAnswerWrong();
            Debug.Log("Wrong");
        }
    }
}
