using System;
using UnityEngine;

public class tickleBotScript : MonoBehaviour
{   
    [SerializeField]
    InfoPlayerScript infoPlayerScript;
    Vector3 positionMe;
    public float speed = 1.0f;
    public float patrolDistance = 5f; // Distance covered in the patrol
    private Vector2 startPosition;
    private Vector2 endPosition;
    private bool isAvance = true;
    public bool isPatrol = false;
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector2(startPosition.x + patrolDistance, startPosition.y);
    
    }

    // Update is called once per frame
    void Update()
    {   
        if(isPatrol && !detectionDeJouer(infoPlayerScript.position_Player(),2,2)){
            patrol();
        } else {
            followPlayer(infoPlayerScript.position_Player(),true);
        }
        
    }

    public void followPlayer(float[] position_player,Boolean isMove){
        if(isMove){
            Vector2 playerPos = new Vector2(position_player[0],position_player[1]);
           
            // Chaser le position X the player

            if(Mathf.Abs(position_player[0] - transform.position.x) >= 1 || Mathf.Abs(position_player[1] - transform.position.y) >= 1 && isMove){
                transform.position = Vector2.MoveTowards(transform.position, playerPos,speed*Time.deltaTime);
            }   else {
                attack();
            }
        }
    }

    public void attack(){
       
        stunPlayer();

     
    }

    public Boolean stunPlayer(){
        // Stun le jouer 
        return true;
    }

    public void patrol(){
        // diametre de patrol
        

        float step = speed * Time.deltaTime;

        if (isAvance)
        {
            transform.position = Vector2.MoveTowards(transform.position, endPosition, step);

            if (Vector2.Distance(transform.position, endPosition) < 0.01f)
            {
                isAvance = false;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, startPosition, step);

            if (Vector2.Distance(transform.position, startPosition) < 0.01f)
            {
                isAvance = true;
            }
        }
    }

    private Boolean detectionDeJouer(float[] position_player,float dist_x, float dist_y){
        if(Mathf.Abs(position_player[0] - transform.position.x) <= dist_x || Mathf.Abs(position_player[1] - transform.position.y) <= dist_y){
            return true;
        }

        return false;
    }
        
        
    
}   
