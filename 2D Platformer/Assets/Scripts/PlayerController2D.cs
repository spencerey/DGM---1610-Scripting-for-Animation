using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{

    // Player stats
    public float speed;
    public float jumpForce;
    private float moveInput; 

    //Player Rigidbody

    private Rigidbody2D rb;
    private bool isFacingRight = true; 

    //Player jump
    
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    public bool doubleJump;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Fixed update is called a fixed or set numbers of frames. This works best with physics based movement
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); //Define what is ground

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        //if the player is moving right but facing left flit the player right
        if(!isFacingRight && moveInput > 0)
        {
            FlipPlayer();
        }

        else if(isFacingRight && moveInput <0)
        {
            FlipPlayer();
        }               

         
    }
    
    // Update is called once per frame. We will us Update for the jump as we will need every frame. Fixed Update skipds frames.

    void Update()
    {
        if(isGrounded)
        {
            doubleJump = true;
        }

        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.velocity = Vector2.up * jumpForce; //Makes player jumo
            doubleJump = false;

        }
        else if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        
    }
    

    void FlipPlayer()
    {
      
        isFacingRight = !isFacingRight;
        
        
        transform.Rotate(0f, 180f, 0f);
    }
}
