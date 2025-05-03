using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlGame : MonoBehaviour
{
    public int op;
    public GameObject strtGame;

    public void Start()
    {
       op = PlayerPrefs.GetInt("isOpen");
    }
    public void Update()
    {
        if (op == 1)
        {
            strtGame.SetActive(true);
        }
    }

    public void Open()
    {
        PlayerPrefs.SetInt("isOpen", 1);
    }
}
