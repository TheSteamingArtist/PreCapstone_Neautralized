using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    Canvas canvas;

    

    

    void Start()
    {
        

        canvas = GameObject.FindGameObjectWithTag("ConversationStarter").GetComponent<Canvas>();

        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canvas)
        {
            Debug.Log("I'm here");
        }
    }



    public void OnTriggerEnter(Collider other)
    {
        canvas.enabled = true;


    }

    public static void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }
}
