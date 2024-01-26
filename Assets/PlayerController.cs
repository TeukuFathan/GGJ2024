using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody2D playerBody;
    private Vector2 velocity;
    private Vector2 inputMovement;
    private Boolean isJumping;
    public Animator animator;

    public void Move(InputAction.CallbackContext ctx){

        inputMovement = ctx.ReadValue<Vector2>();

    }

    public void Jump(InputAction.CallbackContext ctx){

        if(ctx.started){

            isJumping = true;

        }

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
        animator.SetFloat("Speed", inputMovement[0]*40f);
        animator.SetFloat("Vert", inputMovement[1]*40f);
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