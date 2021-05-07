using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class Informant4GC : MonoBehaviour
{
    public Canvas canvas;

    public Rigidbody rb;

    public GameObject player;

    public Info4Dialog info4Dialog;





    void Start()
    {


        canvas = GameObject.FindGameObjectWithTag("Informant4C").GetComponent<Canvas>();

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


        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        player.GetComponent<FirstPersonController>().enabled = false;

        rb.constraints = RigidbodyConstraints.FreezeAll;

    }

    public void OnTriggerExit(Collider other)
    {
        info4Dialog.num1 = 0;
        info4Dialog.num2 = 1;
        info4Dialog.num3 = 2;

        info4Dialog.responseChanger = 0;
    }

    public void EscapeDialog()
    {
        canvas.enabled = false;

        rb.constraints = RigidbodyConstraints.None;

        player.GetComponent<FirstPersonController>().enabled = true;
    }
}
