﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Informant2Collider : MonoBehaviour
{
    public Canvas canvas;

    public Rigidbody rb;

    public Image secondNote;

    public GameObject player;

    public Informant2Dialog informant2Dialog;





    void Start()
    {

        secondNote.GetComponent<Image>().enabled = false;

        canvas = GameObject.FindGameObjectWithTag("Informant2C").GetComponent<Canvas>();

        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapeDialog();
        }
    }



    public void OnTriggerEnter(Collider other)
    {
        canvas.enabled = true;

        secondNote.GetComponent<Image>().enabled = true;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        player.GetComponent<FirstPersonController>().enabled = false;

        rb.constraints = RigidbodyConstraints.FreezeAll;

    }

    public void OnTriggerExit(Collider other)
    {
        informant2Dialog.num1 = 0;
        informant2Dialog.num2 = 1;
        informant2Dialog.num3 = 2;

        informant2Dialog.responseChanger = 0;
    }

    public void EscapeDialog()
    {
        canvas.enabled = false;

        rb.constraints = RigidbodyConstraints.None;

        player.GetComponent<FirstPersonController>().enabled = true;
    }
}
