using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionCheckerScript : MonoBehaviour
{
    
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {


        //Use update on a switch function, which determines 
        MainMissions.killUnderBosses.objectiveCompleted = false;
        MainMissions.RescueNPCs.objectiveCompleted = false;
        MainMissions.FindLocation.objectiveCompleted = false;
        MainMissions.gatherInfo.objectiveCompleted = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(MainMissions.gatherInfo.objectiveCompleted == true)
        {
            RoughNumberManager.progressionNPCS[0].SetActive(false);
            RoughNumberManager.progressionNPCS[1].SetActive(true);
            RoughNumberManager.progressionNPCS[2].SetActive(false);
            RoughNumberManager.progressionNPCS[3].SetActive(false);
        }
        else
        {
            RoughNumberManager.progressionNPCS[0].SetActive(true);
            RoughNumberManager.progressionNPCS[1].SetActive(false);
            RoughNumberManager.progressionNPCS[2].SetActive(false);
            RoughNumberManager.progressionNPCS[3].SetActive(false);
        }

        if(MainMissions.RescueNPCs.objectiveCompleted == true)
        {
            RoughNumberManager.progressionNPCS[0].SetActive(false);
            RoughNumberManager.progressionNPCS[1].SetActive(false);
            RoughNumberManager.progressionNPCS[2].SetActive(true);
            RoughNumberManager.progressionNPCS[3].SetActive(false);
        }
        else
        {
            RoughNumberManager.progressionNPCS[0].SetActive(false);
            RoughNumberManager.progressionNPCS[1].SetActive(true);
            RoughNumberManager.progressionNPCS[2].SetActive(false);
            RoughNumberManager.progressionNPCS[3].SetActive(false);
        }

        if(MainMissions.killUnderBosses.objectiveCompleted == true)
        {
            RoughNumberManager.progressionNPCS[0].SetActive(false);
            RoughNumberManager.progressionNPCS[1].SetActive(false);
            RoughNumberManager.progressionNPCS[2].SetActive(false);
            RoughNumberManager.progressionNPCS[3].SetActive(true);
        }
        else
        {
            RoughNumberManager.progressionNPCS[0].SetActive(false);
            RoughNumberManager.progressionNPCS[1].SetActive(false);
            RoughNumberManager.progressionNPCS[2].SetActive(true);
            RoughNumberManager.progressionNPCS[3].SetActive(false);
        }

        if(MainMissions.FindLocation.objectiveCompleted == true)
        {
            RoughNumberManager.progressionNPCS[0].SetActive(false);
            RoughNumberManager.progressionNPCS[1].SetActive(false);
            RoughNumberManager.progressionNPCS[2].SetActive(false);
            RoughNumberManager.progressionNPCS[3].SetActive(false);
            RoughNumberManager.progressionNPCS[4].SetActive(true);
        }
        else
        {
            RoughNumberManager.progressionNPCS[0].SetActive(false);
            RoughNumberManager.progressionNPCS[1].SetActive(false);
            RoughNumberManager.progressionNPCS[2].SetActive(false);
            RoughNumberManager.progressionNPCS[3].SetActive(true);
            RoughNumberManager.progressionNPCS[4].SetActive(false);
        }
    }
}
