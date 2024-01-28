using System;
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

    public Vector3 newPosition;
    


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
        
        transform.position = transform.position + (Vector3.right * speed) * Time.deltaTime;
        print(transform.position);   
        
    }

    public void moveBlague(Vector2 target){

        Vector3 targetJ = new Vector3(target[0],target[1],0);

       
    }

    public Vector3 MoveInDirection(int directions)
    {
        newPosition = transform.position;

        if (directions == 1)
        {
            newPosition = Vector3.right * speed * Time.deltaTime;
        }
        else if (directions == 2)
        {
            newPosition = Vector3.left * speed * Time.deltaTime;
        }
        else if (directions == 3)
        {
            newPosition = Vector3.up * speed * Time.deltaTime;
        }
        else if (directions == 4)
        {
            newPosition = Vector3.down * speed * Time.deltaTime;
        }

        return newPosition;
    }


    public void respawn(Vector2 translate,Vector2 targettt){
        
        double angle = Math.Cos(targettt[0]);
        float valeurFloat = (float)angle;
        Quaternion rotation = Quaternion.Euler(0, 0, valeurFloat);
        Instantiate(blague,translate,rotation);
        timer = 0;

    }

    

    
}
