using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewDialogSystem : MonoBehaviour
{
    public Text textBox;

    public Text[] Responses;

    public Text[] NPCDialog;

    public List<string> NPCResponse = new List<string>();

    //public List<Text> NPCDialog = new List<Text>();

    public GameController gc = new GameController();

    public int num0 = 0;

    public List<string> PlayerResponse = new List<string>();

    public int num1 = 0;
    public int num2 = 1;
    public int num3 = 2;

    public int buttonClicked = 0;

    public int responseChanger = 0;

    private int isClicked = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NPCDialog[0].text = NPCResponse[responseChanger];

        Responses[0].text = PlayerResponse[num1];
        Responses[1].text = PlayerResponse[num2];
        Responses[2].text = PlayerResponse[num3];




    }

    public void Response1()
    {
        
        isClicked = 1;

        
        if (buttonClicked == 1)
        {

            //First Button Section
            //////////////////////////////////////////
            //First Dialog Button Choice (Branch 1)
            if (responseChanger == 0 && isClicked == 1)
            {
                

                responseChanger = 1;
                num1 = 3;
                num2 = 4;
                num3 = 5;

                isClicked = 0;
                buttonClicked = 0;
            }

            
            //First Button Dialog Choice (Branch 2)
            if(responseChanger == 1 && isClicked == 1)
            {
                responseChanger = 4;

                num1 = 6;
                num2 = 7;
                num3 = 8;

                isClicked = 0;
                buttonClicked = 0;
            }

            if(responseChanger == 4 && isClicked == 1)
            {
                responseChanger = 5;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }

            //Second Button Dialog Choice 1
            if(responseChanger == 2 && isClicked == 1)
            {
                num1 = 18;
                num2 = 19;
                num3 = 20;

                isClicked = 0;
                buttonClicked = 0;
            }

            //Third Button Dialog Choice 1
            if(responseChanger == 3 && isClicked == 1)
            {
                num1 = 30;
                num2 = 31;
                num3 = 32;

                isClicked = 0;
                buttonClicked = 0;
            }

            //First Button Dialog Choice 1 (Branch 3)
            if(responseChanger == 9 && isClicked == 1)
            {
                responseChanger = 11;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
                
            }

            if (responseChanger == 12 && isClicked == 1)
            {
                responseChanger = 15;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }

            //////////////////////////////////////////
            ///

            if(responseChanger == 16 && isClicked == 1)
            {
                responseChanger = 17;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }

            if (responseChanger == 5 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }


            if (responseChanger == 6 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 7 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 8 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 10 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if(responseChanger == 11 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 13 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 14 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 15 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 17 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 18 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 19 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }



        }

        //Button 2
        if (buttonClicked == 2)
        {
            //Second Button Dialog
            if(responseChanger == 0 && isClicked == 1)
            {
                responseChanger = 16;
                num1 = 15;
                num2 = 16;
                num3 = 17;

                isClicked = 0;
                buttonClicked = 0;
            }

            //First Button Dialog Branches
            //////////////////////////////////////////
            //Second Button Dialog Choice 2
            if (responseChanger == 2 && isClicked == 1)
            {
                num1 = 21;
                num2 = 22;
                num3 = 23;

                isClicked = 0;
                buttonClicked = 0;
            }

            //First Button Dialog Choice 2
            if(responseChanger == 1 && isClicked == 1)
            {
                responseChanger = 6;

                num1 = 9;
                num2 = 10;
                num3 = 11;

                isClicked = 0;
                buttonClicked = 0;
            }

            

            //Third Button Dialog Choice 2
            if(responseChanger == 3 && isClicked == 1)
            {
                num1 = 33;
                num2 = 34;
                num3 = 35;

                isClicked = 0;
                buttonClicked = 0;
            }

            if(responseChanger == 4 && isClicked == 1)
            {
                responseChanger = 7;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }

            //First Button Dialog / Second Button of 2nd branch leading to Branch 3(Branch 3)
            if (responseChanger == 9 && isClicked == 1)
            {
                responseChanger = 12;

                num1 = 42;
                num2 = 43;
                num3 = 44;

                isClicked = 0;
                buttonClicked = 0;
            }

            //Branch 3 of First Button Dialog / Second Button Branch / Second Choice
            if(responseChanger == 12 && isClicked == 1)
            {
                responseChanger = 13;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }
            //////////////////////////////////////////
            ///

            if(responseChanger == 16 && isClicked == 1)
            {
                responseChanger = 18;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }


            //No Branch 3 for Choice 2 of Branch 2
            if (responseChanger == 5 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            //No Branch 2 for Choice 2 of branch 1
            if (responseChanger == 6 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if(responseChanger == 7 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 8 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 10 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 11 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 13 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 14 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 15 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 17 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 18 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 19 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

        }


        //Button 3

        
        if (buttonClicked == 3)
        {
            //Third Button Choice
            if(responseChanger == 0 && isClicked == 1)
            {
                responseChanger = 20;

                num1 = 27;
                num2 = 28;
                num3 = 29;

                isClicked = 0;
                buttonClicked = 0;
            }

            //First Button Dialog Branches
            //////////////////////////////////////////
            //First Button Dialog Choice 3 (Branch 1)
            if (responseChanger == 1 && isClicked == 1)
            {   
                responseChanger = 9;

                num1 = 12;
                num2 = 13;
                num3 = 14;

                isClicked = 0;
                buttonClicked = 0;
                //Can be used to exit out of dialog with NPC's
                //this.gameObject.GetComponent<GameController>().EscapeDialog();


            }

            //First Button Dialog Choice 3 (Branch 2)
            if(responseChanger == 9 && isClicked == 1)
            {
                responseChanger = 10;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }

           



            //Second Button Dialog Choice 3
            if(responseChanger == 2 && isClicked == 1)
            {
                num1 = 24;
                num2 = 25;
                num3 = 26;

                isClicked = 0;
                buttonClicked = 0;
            }

            //Third Button Dialog Choice 3
            if(responseChanger == 3 && isClicked == 1)
            {
                num1 = 36;
                num2 = 37;
                num3 = 38;

                isClicked = 0;
                buttonClicked = 0;
            }

            if(responseChanger == 4 && isClicked == 1)
            {
                responseChanger = 8;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }

            if(responseChanger == 12 && isClicked == 1)
            {
                responseChanger = 14;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }

            //////////////////////////////////////////
            ///

            if(responseChanger == 16 && isClicked == 1)
            {
                responseChanger = 19;

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }

            /////////////////////////////////////
            ///

            if (responseChanger == 20 && isClicked == 1)
            {

                num1 = 39;
                num2 = 40;
                num3 = 41;

                isClicked = 0;
                buttonClicked = 0;
            }



            if (responseChanger == 5 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 6 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 7 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if(responseChanger == 8 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if(responseChanger == 10 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 11 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if(responseChanger == 13 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 14 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 15 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 17 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 18 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }

            if (responseChanger == 19 && isClicked == 1)
            {
                this.gameObject.GetComponent<GameController>().EscapeDialog();
            }
        }
    }

    public void Button1()
    {
        buttonClicked = 1;
    }

    public void Button2()
    {
        buttonClicked = 2;
    }

    public void Button3()
    {
        buttonClicked = 3;
    }

}
