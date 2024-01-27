using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class statPlayer : MonoBehaviour
{
    public float barreRire;
    public bool isDead;
    public CapsuleCollider2D playerCapsule;
    public scriptMask maskScript;
    public nezRougeScript nezRougeScript;
    public monoCycleScript monoCycleScript;
    public ChocolatineScript chocolatineScript;
    public ChocolatineScript chocolatineScript2;
    public GameObject mask;
    public GameObject chocolatine;
    public GameObject chocolatine2;
    public GameObject monoCycle;
    public GameObject nezRouge;


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

        if(mask != null){

            if(maskScript.GetCapsuleMask().IsTouching(this.playerCapsule)){

                items[0] = 1;
                Destroy(mask);
                mask = null;

            }
        }

        if(nezRouge != null){

            if(nezRougeScript.GetCapsuleNezRouge().IsTouching(this.playerCapsule)){

                items[1] = 1;
                Destroy(nezRouge);
                nezRouge = null;

            }
        }

        if(monoCycle != null){

            if(monoCycleScript.GetCapsuleMonoCycle().IsTouching(this.playerCapsule)){

                items[2] = 1;
                Destroy(monoCycle);
                monoCycle = null;

            }
        }

        if(chocolatine != null){

            if(chocolatineScript.GetCapsuleChocolatine().IsTouching(this.playerCapsule)){

                items[3] = 1;
                Destroy(chocolatine);
                chocolatine = null;

            }
        }

        if(chocolatine2 != null){

            if(chocolatineScript2.GetCapsuleChocolatine().IsTouching(this.playerCapsule)){

                items[4] = 1;
                Destroy(chocolatine2);
                chocolatine2 = null;

            }
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
