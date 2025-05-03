using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScnMaster : MonoBehaviour
{
    [SerializeField] float Timeremain;

    public Collider2D me;
    public string scn;
    public GameObject loadSc;

    public SpriteRenderer shade;
    public float vf = 0f;
    public bool isDark = false;

    public void Update()
    {
        if (isDark == true) 
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
            if (vf == 0f && shade.color.a > 0f)
            {
                var op = shade.color;
                op.a -= 0.05f;
                shade.color = op;
            }
            if (vf == 1)
            {
                var op = shade.color;
                op.a += 0.05f;
                shade.color = op;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            itStrtLoad();
        }
    }

    public void itStrtLoad() 
    {
        isDark = true;
    }

    public void ChangeScene()
    {
        loadSc.SetActive(true);
        StartCoroutine(LoadAsyng());
    }

    IEnumerator LoadAsyng()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scn);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
