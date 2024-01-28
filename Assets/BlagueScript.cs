using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlagueScript : MonoBehaviour
{

    public float damage;
    public int speed = 10;
    public Vector2 inputMovement;
    public bool isTired = false;
    private Rigidbody2D playerBody;


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

        if(isTired == true){

           

        }
        
    }

    

    
}
