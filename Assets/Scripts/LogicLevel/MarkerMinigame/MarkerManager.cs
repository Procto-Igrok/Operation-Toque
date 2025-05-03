using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerManager : MonoBehaviour
{
    public Text resultText; // UI-текст для отображения результата
    private string currentMessage = "Попробуй еще раз"; // Сообщение по умолчанию

    private void OnTriggerEnter2D(Collider2D other)
    {
    
        Debug.Log("Метка столкнулась с: " + other.gameObject.name); // Проверка столкновения
        if (other.CompareTag("greenZone"))
        {
            currentMessage = "Повезло";
            Debug.Log("Попала в ЗЕЛЕНУЮ зону");
        }
        else if (other.CompareTag("redZone"))
        {
            currentMessage = "Попробуй еще раз";
            Debug.Log("Попала в КРАСНУЮ зону");
        }
    }
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Space)) // Нажатие пробела
            {
                resultText.text = currentMessage;
            }
        }
    }

}


