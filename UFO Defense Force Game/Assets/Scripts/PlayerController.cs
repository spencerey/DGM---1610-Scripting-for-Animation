using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float hInput; //Horizontal movement
    public float speed;

    private float xRange = 11.0f ; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontal input to receive values from the keyboard, keymap horizontal -1 - 1
        hInput = Input.GetAxis("Horizontal"); //InputManager settings

        //move player left to right
        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);

        //Key player within set boundaries (Player wont go out of boundaries)
        //key player inside right wall at set xRange = 10
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        

    }
}
