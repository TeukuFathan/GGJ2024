using System;
using System.Collections;
using System.Collections.Generic;

using System.Threading;
using UnityEditor;
using UnityEngine;

public class scriptBlague : MonoBehaviour
{   

    public GameObject Blague;
    private float spawnRate = 2;
    private float timer = 0;

    public float speed = 5;
    public Quaternion MyGameObjectRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //transform.position = transform.position + (Vector3.right * speed) * Time.deltaTime;
    }

    public void respawn(Boolean spawn,Vector2 translate,Quaternion rotation){
        
        Instantiate(Blague,translate,rotation);
        timer = 0;

    }



    
}
