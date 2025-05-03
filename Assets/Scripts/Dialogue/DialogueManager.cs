using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI nameText;

    public GameObject DialWind;
    public GameObject StartDial;

    private Queue<string> sentences;
    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dial) 
    {
        rbPlayer.constraints = RigidbodyConstraints2D.FreezePositionX;
        rbPlayer.constraints = RigidbodyConstraints2D.FreezePositionY;
        DialWind.SetActive(true);
        StartDial.SetActive(false);

        nameText.text = dial.name;
        sentences.Clear();
        foreach (string sentence in dial.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
        
    }
    
    

    public void DisplayNextSentence() 
    { 
        if(sentences.Count == 0) 
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()) 
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue() 
    {

        rbPlayer.constraints = RigidbodyConstraints2D.None;
        rbPlayer.constraints = RigidbodyConstraints2D.FreezeRotation;
        DialWind.SetActive(false);
    }
}
