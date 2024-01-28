using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 10;
    private Rigidbody2D playerBody;
    private Vector2 velocity;
    public Vector2 inputMovement;
    private bool isJumping;
    public Vector2 target;
    public Animator animator;
    private bool isSpell1;
    private bool isSpell2;
    private bool isSpell3;
    private bool isSpell4;

    public void Jump(InputAction.CallbackContext ctx){

        if(ctx.started){

            isJumping = true;

        }

    }

    public void upSpell1(InputAction.CallbackContext ctx){

        if(ctx.started){

            isSpell1 = true;

        }

    }

    public void upSpell2(InputAction.CallbackContext ctx){

        if(ctx.started){

            isSpell2 = true;

        }

    }

    public void upSpell3(InputAction.CallbackContext ctx){

        if(ctx.started){

            isSpell3 = true;

        }

    }

    public void upSpell4(InputAction.CallbackContext ctx){

        if(ctx.started){

            isSpell4 = true;

        }

    }

    public void Move(InputAction.CallbackContext ctx){

        inputMovement = ctx.ReadValue<Vector2>();

    }

    public void Target(InputAction.CallbackContext ctx){

        target = ctx.ReadValue<Vector2>();

    }

 

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(speed,speed);
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", inputMovement[0]*40f);
        animator.SetFloat("Vertical", inputMovement[1]*40f);
        inputMovement = new Vector2(
            inputMovement[0],
            inputMovement[1]
        );
        if(isJumping){

            animator.SetBool("Attack",true);
            isJumping = false;

        }
        else{
            animator.SetBool("Attack",false);
        }
    }

    private void FixedUpdate()
    {
       Vector2 delta = inputMovement*velocity*Time.deltaTime;
       Vector2 newPosition = playerBody.position + delta;
       playerBody.MovePosition(newPosition);
    }

}
