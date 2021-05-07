using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class OBradyColliderScript : MonoBehaviour
{
    public Canvas canvas;

    public Rigidbody rb;

    public GameObject player;

    public OBradyDScript oBradyD;





    void Start()
    {


        canvas = GameObject.FindGameObjectWithTag("OBradyConversationStarter").GetComponent<Canvas>();

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
        oBradyD.num1 = 0;
        oBradyD.num2 = 1;
        oBradyD.num3 = 2;

        oBradyD.responseChanger = 0;
    }

    public void EscapeDialog()
    {
        canvas.enabled = false;

        rb.constraints = RigidbodyConstraints.None;

        player.GetComponent<FirstPersonController>().enabled = true;
    }
}
