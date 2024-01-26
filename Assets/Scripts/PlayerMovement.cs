using UnityEngine;
using UnityEngine.Tilemaps;
/*
public class PlayerMovement : MonoBehaviour
{
    public int speed = 10;
    private Rigidbody2D playerBody;
    private Vector2 velocity;
    private Vector2 inputMovement;
    public Animator animator;
 

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(speed,speed);
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Input.GetAxisRaw("Horizontal")*40f);
        animator.SetFloat("Vert", Input.GetAxisRaw("Vertical")*40f);
        inputMovement = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
        if(Input.GetButtonDown("Jump")){

            animator.SetBool("Attack",true);

        }
        else{
            animator.SetBool("Attack",false);
        }
    }

    private void FixedUpdate()
    {
       Vector2 delta = inputMovement*velocity*Time.deltaTime;
       Vector2 newPosition = playerBody.position + delta;
       playerBody.MovePosition(newPosition);
    }
}
*/