using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float hInput; //Horizontal movement
    public float speed;

    private float xRange = 17.0f ; 

    public GameObject lazerBolt; //GameObject Projectile to shoot
    public Transform blaster; // Point of origin for the lazerBolt
    
    //Audio variables
    private AudioSource blasterAudio;

    //Store audio
    public AudioClip laserBlast; 




    // Start is called before the first frame update
    void Start()
    {
        blasterAudio = GetComponent<AudioSource>();
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
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            blasterAudio.PlayOneShot(laserBlast, 1.0f);
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation); // instantiate lazerBolt Game object at blaster position
        }


    }
}
