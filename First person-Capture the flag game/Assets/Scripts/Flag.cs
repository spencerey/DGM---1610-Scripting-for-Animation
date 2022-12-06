using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{

    private GameManager gm ;
    private Renderer rend; 


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();//find gameManager and reference the gamemanager component
        rend = GetComponent<Renderer>(); //Renderer the game component
        rend.enabled = true; 
    }

    void  OnTriggerEnter(Collider other)
    {
        gm.hasFlag = true; // Get flag and set bool hasFlag to true
        rend.enabled = false; //hode the flag using the Renderer
    }
}
