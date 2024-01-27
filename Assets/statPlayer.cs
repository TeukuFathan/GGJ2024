using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statPlayer : MonoBehaviour
{
    public int barreRire;
    public bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        barreRire = 0;
        isDead = false;
    }

    void Update()
    {
        if(barreRire >= 100){

            this.isDead = true;

        }
    }

    public void healPlayer(int heal){

        if( (barreRire-heal)<0 ){

            barreRire = 0;

        }
        else{

            barreRire = barreRire - heal;

        }

    }

    public void hitPlayer(int hit){

        if( (barreRire+hit)>100 ){

            barreRire = 100;

        }
        else{

            barreRire = barreRire + hit;

        }

    }

}
