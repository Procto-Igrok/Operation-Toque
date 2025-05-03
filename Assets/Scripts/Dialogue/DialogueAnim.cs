using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnim : MonoBehaviour
{
    public GameObject StartDial;
    public DialogueManager dm;

    public void OnTriggerEnter2D(Collider2D other)
    {
        StartDial.SetActive(true);
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        StartDial.SetActive(false);
        dm.EndDialogue();
    }
}
