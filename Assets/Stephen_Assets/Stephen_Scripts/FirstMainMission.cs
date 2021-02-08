using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstMainMission : MonoBehaviour
{
    private Canvas canvas;

    private Text text;

    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("InfoGather").GetComponent<Canvas>();
        text = canvas.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(RoughNumberManager.infoGather == 10)
        {
            GatheredAllInformation();
            MainMissions.gatherInfo.objectiveCompleted = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        RoughNumberManager.infoGather++;
        text.text = "Successfully gathered piece of information!";
    }
    

    void GatheredAllInformation()
    {

        canvas = GameObject.FindGameObjectWithTag("CompleteMission").GetComponent<Canvas>();

        text.text = "Agent please return back to HQ..You've gathered sufficient info";

        foreach(GameObject button in NPC.buttons)
        {
            button.SetActive(false);
        }

        foreach(GameObject conversation in NPC.conversationReset)
        {
            conversation.SetActive(false);
        }    
    }
}
