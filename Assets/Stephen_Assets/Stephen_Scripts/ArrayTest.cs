using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArrayTest : MonoBehaviour
{
    //public static int maxValueOfArrays = 16;
    //public Text[] texts = new Text[maxValueOfArrays];


    public string[] alltext = { "A", "B", "C" };


    public int textCounter = 0;

    public Text text;


    void Start()
    {
        text = GameObject.FindWithTag("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //for(int i = 0; i < textObjects.Length; i++)
        //{
        //    textObjects[i].SetActive(false);
        //}



        if(Input.GetKeyDown(KeyCode.Return))
        {
            if (textCounter == 0)
                text.gameObject.SetActive(true);

            if (textCounter < alltext.Length)
                text.text = alltext[textCounter] + "\n [Press Enter/Return to Continue]";
            else
            {
                text.gameObject.SetActive(false);
                SceneManager.LoadScene(1);
            }

            textCounter++;
        }


        //for (int i = 0; i < texts.Length; i++)
        //{
        //    if(Input.GetKeyDown(KeyCode.A))
        //    {
        //        Debug.Log("This is the values before" + i);

        //        i = i + 1;

        //        Debug.Log("This is the values after" + i);
        //    }
        //}
    }

    //static int NumberChecker(int i)
    //{
        

       

    //    return i;
    //}
}
