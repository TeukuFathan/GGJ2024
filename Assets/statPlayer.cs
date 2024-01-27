using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statPlayer : MonoBehaviour
{
    public float barreRire;
    public bool isDead;
    public CapsuleCollider2D playerCapsule;
    public scriptMask maskItem;

    public int[] items = new int[5];

    // Start is called before the first frame update
    void Start()
    {
        barreRire = 0;
        isDead = false;
        items[0] = 0;
        items[1] = 0;
        items[2] = 0;
        items[3] = 0;
        items[4] = 0;
    }

    void Update()
    {
        if(barreRire >= 100){

            this.isDead = true;

        }

        if(this.maskItem.GetCapsuleMask().IsTouching(this.playerCapsule)){

            items[0] = 1;

        }
    }

    public void healPlayer(float heal){

        if( (barreRire-heal)<0 ){

            barreRire = 0;

        }
        else{

            barreRire = barreRire - heal;

        }

    }

    public void hitPlayer(float hit){

        if( (barreRire+hit)>100 ){

            barreRire = 100;

        }
        else{

            barreRire = barreRire + hit;

        }

    }

    public float getBarreRire(){

            return barreRire;

    }

}
