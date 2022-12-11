using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [Header ("Stats")]

    public float moveSpeed; //player speed movement
    public float jumpForce; // player jump force
    public int curHp;
    public int maxHp;
    
    [Header("Mouse Look")]
    public float lookSensitivity ; // How sensitive we will be able to look around
    public float maxLookX; // How far up we can look
    public float minLookX; //How far down we can look
    private float rotX ; 
    
    private Camera camera; 
    private Rigidbody rb;



    void Awake ()
    {
        curHp = maxHp;
        
    }

    void Start()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }


    public void TakeDamage (int damage)
    {
        curHp -= damage;
        if(curHp <= 0)
            Die();
    }

    void Die()
    {
        Debug.Log("Player has died! Game over!");
        Time.timeScale = 0 ; 
    }

    void LoseGame()
    {
        Debug.Log("You lost");
    }
    
    public void GiveHealth (int amountToGive)
    {
        Debug.Log("Player has been healed");
       
       
    }

    public void GiveAmmo (int amountToGive)
    {
        Debug.Log("Player has collected ammo!!");
    }

    
    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; // Getting input for left and right movement
        float z = Input.GetAxis("Vertical") * moveSpeed; // Getting input for forward and back movement

        //move direction relative to camera
        Vector3 dir = transform.right * x + transform.forward * z; 
        
        dir.y = rb.velocity.y ; 
        rb.velocity = dir;         
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity; // look up and down
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity; // look left and right

        //Restrict movement on the X-Axis between maxLook
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);

        //Drives camera rotation
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0); //calculate rotation
        transform.eulerAngles += Vector3.up * y; 

    }


    void Jump()
    {
        Ray ray = new Ray (transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();

        if(Input.GetButtonDown ("Jump"))         
            Jump();
        
        
    }

}
