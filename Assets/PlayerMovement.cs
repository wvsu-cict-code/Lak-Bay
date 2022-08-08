using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller; //add controller under the script
    
    public Animator animator;

    public Joystick joystick; //Playermovement script add or drag fixed joystick
    
    public float runSpeed = 40f; //speed of run
    
    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;
    
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") + runSpeed;

        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = runSpeed;
        }
            else if (joystick.Horizontal <= -.2f)
        {
            horizontalMove = -runSpeed;
        }
            else
        {
            horizontalMove = 0f;
        }


        float verticalMove = joystick.Vertical;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (verticalMove >= .7f)
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (verticalMove <= -.7)
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
            }
    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching (bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }



    void FixedUpdate ()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump); //first false dont want to crouch second dont want to jump
        jump = false;
        //crouch = false;kakas ni
    }
}
