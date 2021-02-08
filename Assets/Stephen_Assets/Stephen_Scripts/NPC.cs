using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;

    public Text nameText;
    public Text dialogueText;

    public SentenceHolder[] dialog;

    public static Queue<string> sentences;

    public static Queue<string>[] sentences2;

    public static GameObject[] buttons;

    public static GameObject[] conversationReset;


    public void TriggerDialogue(Dialogue dialogue)
    {
        
    }

    public void Start()
    {
        sentences = new Queue<string>();
    }

    //string sentence = sentences.Dequeue();


    public void OnTriggerEnter(Collider other)
    {

        foreach(GameObject button in buttons)
        {
            button.SetActive(true);
        }    


        SentenceHolder[] holders = GetComponents<SentenceHolder>();

        dialog = new SentenceHolder[holders.Length];


        Debug.Log(holders.Length);

        for(int i = 0; i < holders.Length; i++)
        {
            Debug.Log(holders[i]);
            foreach(SentenceHolder holder in holders)
            {
                if(holder.buttonNumber == i)
                {
                    Debug.Log(i);
                    dialog[i] = holder;
                    break;
                }
            }
        }

        nameText.text = dialogue.name;

        sentences.Clear();

        

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
         
        
        //Debug.Log(sentence);
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            DisplayNextSentence();
        }
    }

    public void EnqueueSentences(int index)
    {
        sentences.Clear();
        foreach (string sentence in dialog[index].sentences)
        {
            Debug.Log(sentence);
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();

        foreach(GameObject button in buttons)
        {
            button.SetActive(false);
        }
    }


    public void DisplayNextSentence()
    {


        if (sentences.Count == 0)
        {
            Debug.Log("End of Conversation");

            foreach(GameObject conversation in conversationReset)
            {
                conversation.SetActive(true);
            }
            return;
        }
        else
        {
            foreach(GameObject conversation in conversationReset)
            {
                conversation.SetActive(false);
            }
        }

        

        string sentence = sentences.Dequeue();

        dialogueText.text = sentence;

    }

    public void Button0()
    {
        EnqueueSentences(0);
    }

    public void Button1()
    {
        EnqueueSentences(1);
    }

    public void Button2()
    {
        EnqueueSentences(2);
    }


    public void StoryResponse()
    {
        //sentences.Enqueue("You're finally here Agent R014. We've been waiting for you're return. \n ");



        dialogueText.text = sentences.Dequeue();


    }

    public void ConversationResetter()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }


        SentenceHolder[] holders = GetComponents<SentenceHolder>();

        dialog = new SentenceHolder[holders.Length];


        Debug.Log(holders.Length);

        for (int i = 0; i < holders.Length; i++)
        {
            Debug.Log(holders[i]);
            foreach (SentenceHolder holder in holders)
            {
                if (holder.buttonNumber == i)
                {
                    Debug.Log(i);
                    dialog[i] = holder;
                    break;
                }
            }
        }

        nameText.text = dialogue.name;

        sentences.Clear();



        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }


    void OnTriggerExit(Collider other)
    {
        
    }
}
