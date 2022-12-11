using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : MonoBehaviour
{

    private GameManager gm;
    private Renderer flagRend; 


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        flagRend = GameObject.Find("FlagHome").GetComponent<Renderer>();

        flagRend.enabled = false; // Hide Flag
    }

    void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("Player has reached home base");
        Debug.Log("you've won");
        
        if(other.CompareTag("Player") && gm.hasFlag)
        {
            
            gm.PlaceFlag(); // run place flag function in game manager. 
            flagRend.enabled = true; //Make flag visible
        }
    }
}
