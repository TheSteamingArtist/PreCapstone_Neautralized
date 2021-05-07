using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class StartOfGame : MonoBehaviour
{
    public Rigidbody rb;

    public GameObject player;

    public Canvas canvas;


    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("StartGame").GetComponent<Canvas>();

        StartCoroutine(StartGame());
    }

    void Update()
    {
        
    }


    IEnumerator StartGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        player.GetComponent<FirstPersonController>().enabled = false;

        rb.constraints = RigidbodyConstraints.FreezeAll;

        canvas.enabled = true;

        yield return new WaitForSeconds(5);

        canvas.enabled = false;

        rb.constraints = RigidbodyConstraints.None;

        player.GetComponent<FirstPersonController>().enabled = true;
    }
}
