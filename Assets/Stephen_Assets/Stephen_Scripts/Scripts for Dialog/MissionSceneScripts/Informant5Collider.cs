using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Informant5Collider : MonoBehaviour
{
    public Canvas canvas;

    public Rigidbody rb;

    public Image fifthNote;

    public GameObject player;

    

    public Informant5Dialog informant5Dialog;





    void Start()
    {
        fifthNote.GetComponent<Image>().enabled = false;

        canvas = GameObject.FindGameObjectWithTag("Informant5C").GetComponent<Canvas>();

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

        fifthNote.GetComponent<Image>().enabled = true;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        player.GetComponent<FirstPersonController>().enabled = false;

        rb.constraints = RigidbodyConstraints.FreezeAll;

    }

    public void OnTriggerExit(Collider other)
    {
        informant5Dialog.num1 = 0;
        informant5Dialog.num2 = 1;
        informant5Dialog.num3 = 2;

        informant5Dialog.responseChanger = 0;
    }

    public void EscapeDialog()
    {
        canvas.enabled = false;

        rb.constraints = RigidbodyConstraints.None;

        player.GetComponent<FirstPersonController>().enabled = true;
    }
}
