using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Informant3Collider : MonoBehaviour
{
    public Canvas canvas;

    public Rigidbody rb;

    public GameObject player;

    public Image thirdNote;

    public Info3Dialog info3Dialog;





    void Start()
    {

        //Used to get the conversation of each individual NPC
        //Canvas is set to false in the beginning and
        //Then a OntriggerEnter is used to bring up Canvas
        canvas = GameObject.FindGameObjectWithTag("Informant3C").GetComponent<Canvas>();

        //thirdNote.GetComponent<Image>().enabled = false;

        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Used to exit out of dialog with NP
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapeDialog();
        }
    }



    public void OnTriggerEnter(Collider other)
    {
        //Used to bring up the conversation between the NPC and the player
        canvas.enabled = true;

        //thirdNote.GetComponent<Image>().enabled = true;
        //These are all used to stop the movement of the player
        //Make it so that you can only click buttons on screen
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        player.GetComponent<FirstPersonController>().enabled = false;

        rb.constraints = RigidbodyConstraints.FreezeAll;
        ///////////////////////
        ///

    }

    public void OnTriggerExit(Collider other)
    {
        //Sets numbers back to original conversation when player first talked to NPC

        info3Dialog.num1 = 0;
        info3Dialog.num2 = 1;
        info3Dialog.num3 = 2;

        info3Dialog.responseChanger = 0;
    }

    public void EscapeDialog()
    {
        canvas.enabled = false;

        rb.constraints = RigidbodyConstraints.None;

        player.GetComponent<FirstPersonController>().enabled = true;
    }
}
