using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;

    public Text nameText;
    public Text dialogueText;

    public static Queue<string> sentences;

    public void TriggerDialogue(Dialogue dialogue)
    {
        
    }

    public void Start()
    {
        sentences = new Queue<string>();
    }

    string sentence = sentences.Dequeue();


    public void OnTriggerEnter(Collider other)
    {
        nameText.text = dialogue.name;

        sentences.Clear();

        

        //foreach (string sentence in dialogue.sentences)
        //{
        //    sentences.Enqueue(sentence);
        //}

        //dialogueText.text = sentence;

        DisplayNextSentence();

        
        Debug.Log(sentence);
    }





    public void DisplayNextSentence()
    {


        if (sentences.Count == 0)
        {
            Debug.Log("End of Conversation");
            return;
        }

        

        string sentence = sentences.Dequeue();

        dialogueText.text = sentence;

    }


    public void StoryResponse()
    {
        sentences.Enqueue("You're finally here Agent R014. We've been waiting for you're return. \n ");



        dialogueText.text = sentences.Dequeue();


    }
}
