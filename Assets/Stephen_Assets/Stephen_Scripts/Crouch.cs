using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public CharacterController my_Character_Controller;

    private float originalHeight;

    private bool myCrouch = false;

    [SerializeField]
    private float crouchHeight = 0.5f;
    void Start()
    {
        my_Character_Controller = GetComponent<CharacterController>();

        originalHeight = my_Character_Controller.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            myCrouch = true;

            CheckCrouching();
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            my_Character_Controller.height = originalHeight;
        }    
    }

    void CheckCrouching()
    {
        if (myCrouch == true)
        {
            my_Character_Controller.height = crouchHeight;
        }
        else
        {
            my_Character_Controller.height = originalHeight;
        }
    }

    
}

    
