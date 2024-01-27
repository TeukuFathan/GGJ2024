using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class projetileScript : MonoBehaviour
{   
    public float speed = 1.3f;
    public float Velocity = 2;
    public Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vole(true);
    }

    public void vole(Boolean isVole){
        float acDePesanteur = 9.81f * Time.deltaTime * 0.1f;

        if(isVole && Velocity >= 0){
            Velocity -= 2*Time.deltaTime;
            transform.position = new Vector2(transform.position.x + speed*(Velocity*Time.deltaTime),transform.position.y - acDePesanteur);
        } else {
            rigidBody2D.velocity = Vector2.zero;
        }
    }
}
