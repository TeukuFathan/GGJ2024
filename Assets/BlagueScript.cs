using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BlagueScript : MonoBehaviour
{

    public float damage;
    public float speed = 10;
    public Vector2 inputMovement;
    public bool isTired = false;
    private Rigidbody2D playerBody;
    public GameObject blague;
    private float spawnRate = 2;
    private float timer = 0;


    public void TireBlague(Vector2 target){

        isTired = true;
        inputMovement = playerBody.position;
        this.transform.position = inputMovement;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       // transform.position = transform.position + ( * speed) * Time.deltaTime;

    }

    public void moveBlague(Vector2 target){

        Vector3 targetJ = new Vector3(target[0],target[1],0);

        transform.position = transform.position + ( targetJ * speed) * Time.deltaTime;

    }

    public void respawn(bool spawn,Vector2 translate,Vector2 targettt){
        
        double angle = Math.Cos(targettt[0]);
        float valeurFloat = (float)angle;
        Quaternion rotation = Quaternion.Euler(0, 0, valeurFloat);
        Instantiate(blague,translate,rotation);
        timer = 0;

    }

    

    
}
