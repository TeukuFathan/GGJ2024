using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanScript : MonoBehaviour
{
    public Rigidbody2D human;
    public Animator animator;
    public int flapStrength = 5;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bob";
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space)){
            human.velocity = Vector2.up * flapStrength;
            animator.SetBool("jump",true);
        }
        else {
            animator.SetBool("jump",false);

        }
        if(Input.GetKeyDown(KeyCode.D)){
            human.velocity = Vector2.right * 3;
            animator.SetFloat("Speed",2);
        }
        else {
            animator.SetFloat("Speed",0);
        }
    }
}
