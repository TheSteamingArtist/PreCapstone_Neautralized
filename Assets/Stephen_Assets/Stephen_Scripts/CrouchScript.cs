using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchScript : MonoBehaviour
{
    CharacterController thiscol;
    public float originalHeight;
    public float shorterHeight;
    void Start()
    {
        thiscol = GetComponent<CharacterController>();
        originalHeight = thiscol.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            Crouch();
        else if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            StandUp();
        }
    }

    void Crouch()
    {
        thiscol.height = shorterHeight;
    }

    void StandUp()
    {
        thiscol.height = originalHeight;
    }
}
