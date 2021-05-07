using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainMissions : MonoBehaviour
{

    public static Text text;

    public static OFMMScript killUnderBosses, FindLocation, RescueNPCs, gatherInfo;

    public enum playerObjectives { MAINQUESTBEGINNING,ESSENTIALINFO, KILLBOSS, FINDLOSTAGENTS};

    public static Canvas canvas;

    private bool uiON;

    public static playerObjectives playerO;

    public static playerObjectives setmission;

    void mainUserInterface()
    {
        canvas = GameObject.FindGameObjectWithTag("PlayerMMUI").GetComponent<Canvas>();

        killUnderBosses = new OFMMScript(1, "Kill all bosses connected to leader and gain information", false);

        FindLocation = new OFMMScript(2, "Find the location of the main leader", false);

        RescueNPCs = new OFMMScript(3, "Rescue all important captured personell", false);

        canvas.enabled = true;

        text = canvas.GetComponent<Text>();

        text.text = killUnderBosses + "/n" + FindLocation + "/n" + RescueNPCs;


       
    }



    //Function to start first main mission
    public static void FirstMainMission()
    {
        canvas = GameObject.FindGameObjectWithTag("Beginnings").GetComponent<Canvas>();

        killUnderBosses = new OFMMScript(1, "Kill all bosses connected to leader and gain information", false);

        canvas.enabled = true;


    }


    IEnumerator mainChecker()
    {
        while(uiON)
        {
            //After exiting the trigger you want to set the mission =
            if (setmission != playerO)
            {
                switch (setmission)
                {
                    //if the state is mainquestbeginning make UI show.
                    case playerObjectives.MAINQUESTBEGINNING:

                        mainUserInterface();

                        break;


                }
                playerO = setmission;
            }

            



        }

            yield return null;
    }



    
}





