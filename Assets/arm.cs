using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;

public class arm : MonoBehaviour
{   
    public scriptBlague scriptBlague;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space)){
            Quaternion test = Quaternion.Euler(0, 0, 45);
            Vector2 TEST2 = new Vector2(1,1);
            lanceBlague(test,TEST2);
        }
        
    }
     public void lanceBlague(Quaternion newRotation, Vector2 stickDroit){

        double xCos = Math.Cos(newRotation[2]);
        double ySin = Math.Sin(newRotation[2]);

        Vector2 pos = new Vector2(transform.position.x+(int)xCos*2,transform.position.y+(int)ySin*2);
        // Prends le rotation et le position de le rouge 
        
        scriptBlague.respawn(true,pos,newRotation );
    }
}
