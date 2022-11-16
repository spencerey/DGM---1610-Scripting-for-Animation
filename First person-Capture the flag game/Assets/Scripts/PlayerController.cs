using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [Header ("Player Movement")]

    public float moveSpeed; //player speed movement
    public float jumpForce; // player jump force
    
    [Header("Camera")]
    public float lookSensitivity ; // How sensitive we will be able to look around
    public float maxLookX; // How far up we can look
    public float minLookX; //How far down we can look
    private float rotX ; 
    
    private Camera camera; 
    private Rigidbody rb;

    void Awake ()
    {
        //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();

        if(Input.GetButtonDown ("Jump")) 
        {
            Jump();
        }
        
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector3(x, rb.velocity.y, z);
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity; // look up and down
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity; // look left and right

    }

    void Jump()
    {
        Ray ray = new Ray (transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
