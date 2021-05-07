using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info4Dialog : MonoBehaviour
{
    public Text textBox;

    public Text[] Responses;

    public Text[] NPCDialog;

    public List<string> NPCResponse = new List<string>();

    //public List<Text> NPCDialog = new List<Text>();

    public Informant4GC gc = new Informant4GC();

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

    public void Response8()
    {
        isClicked = 1;

        if (buttonClicked == 1 && isClicked == 1)
        {
            if(responseChanger == 0 && isClicked == 1)
            {
                responseChanger = 1;

                num1 = 3;
                num2 = 4;
                num3 = 5;

                buttonClicked = 0;
                isClicked = 0;
            }

            if(responseChanger == 1 && isClicked == 1)
            {
                responseChanger = 2;

                num1 = 6;
                num2 = 7;
                num3 = 8;

                buttonClicked = 0;
                isClicked = 0;
            }

            if (responseChanger == 6 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 4 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 3 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 5 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 2 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }
        }

        if (buttonClicked == 2 && isClicked == 1)
        {
            if(responseChanger == 0 && isClicked == 1)
            {
                responseChanger = 5;

                num1 = 6;
                num2 = 7;
                num3 = 8;

                buttonClicked = 0;
                isClicked = 0;
            }


            if(responseChanger == 1 && isClicked == 1)
            {
                responseChanger = 3;

                num1 = 6;
                num2 = 7;
                num3 = 8;

                buttonClicked = 0;
                isClicked = 0;
            }

            if (responseChanger == 6 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 4 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 3 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 5 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 2 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }
        }

        if (buttonClicked == 3 && isClicked == 1)
        {
            if(responseChanger == 1 && isClicked == 1)
            {
                responseChanger = 4;

                num1 = 6;
                num2 = 7;
                num3 = 8;

                buttonClicked = 0;
                isClicked = 0;
            }

            if(responseChanger == 0 && isClicked == 1)
            {
                responseChanger = 6;

                num1 = 6;
                num2 = 7;
                num3 = 8;

                buttonClicked = 0;

                isClicked = 0;
            }

            if (responseChanger == 6 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 4 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 3 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 5 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
            }

            if (responseChanger == 2 && isClicked == 1)
            {
                this.gameObject.GetComponent<Informant4GC>().EscapeDialog();
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
