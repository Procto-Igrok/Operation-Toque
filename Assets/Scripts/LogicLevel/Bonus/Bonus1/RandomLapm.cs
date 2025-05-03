using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLapm : MonoBehaviour
{
    public GameObject wrongLightPrefab; // Префаб книги
    public GameObject correctLightPrefab; // Префаб машинки
    public Transform[] spawnPoints; // Массив точек появления\
    public GameObject result;
    public GameObject NonBut;

    public int level = 0;
    public int levelCount = 0;

    public void OnAnswChoose()
    {
        if (level != levelCount)
        { 
            SpawnObjects();
            level += 1;
        }
        if (level >= levelCount) 
        {
            result.SetActive(true);
            NonBut.SetActive(false);
        }
    }

    private void SpawnObjects()
    {
        // Перемешиваем точки появления
        ShuffleArray(spawnPoints);

        int carSpawned = 0; // Счетчик для машинки
        int booksSpawned = 0; // Счетчик для книг

        foreach (Transform spawnPoint in spawnPoints)
        {
            // Если машинка еще не появилась, то с вероятностью 1/5 создаем машинку
            if (carSpawned == 0 && Random.Range(0, 5) == 0)
            {
                Instantiate(correctLightPrefab, spawnPoint.position, Quaternion.identity);
                carSpawned++;
            }
            // Если книг еще меньше 4, создаем книгу
            else if (booksSpawned < 4)
            {
                Instantiate(wrongLightPrefab, spawnPoint.position, Quaternion.identity);
                booksSpawned++;
            }
        }
    }

    private void ShuffleArray(Transform[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Transform temp = array[i];
            int randomIndex = Random.Range(i, array.Length);
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }
}

