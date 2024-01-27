using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPlayerScript : MonoBehaviour
{   
    private float coor_x;
    private float coor_y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        position_Player();
    }

    public float[] position_Player(){

        coor_x = transform.position.x;

        coor_y = transform.position.y;

        return new float[] {coor_x, coor_y};
    }
}
