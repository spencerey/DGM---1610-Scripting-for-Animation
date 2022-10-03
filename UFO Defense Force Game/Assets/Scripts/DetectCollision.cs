using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour    
{
    private ScoreManager scoreManager; //A variable to hold the reference to score manager
    public int scoreToGive; 


    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //reference score manager
        
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); //Increase score 
        Destroy(other.gameObject); // Destroy this game object (whatever the script is on)
        Destroy(gameObject); // Destroy other game object that passes trhough the trigger

    }
   
}
