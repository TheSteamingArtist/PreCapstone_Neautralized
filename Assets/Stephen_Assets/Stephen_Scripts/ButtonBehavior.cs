using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class ButtonBehavior : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public bool onRun = true;

    void Start()
    {
        button2.enabled = false;

        button3.enabled = false;


    }

    // Update is called once per frame
    void Update()
    { 
      
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        eventData.selectedObject = gameObject;

        if (eventData.selectedObject = gameObject)
        {
            Debug.Log("I've hit this button");
        }

        
    }

    public void Active()
    {
        button2.enabled = false;
        button3.enabled = false;
    }
}
