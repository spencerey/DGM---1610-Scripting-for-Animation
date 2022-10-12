using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour    
{
    public ScoreManager scoreManager; //A variable to hold the reference to score manager
    public int scoreToGive; 
    public ParticleSystem explosionParticle; //Store the particle system

    
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); //reference score manager
        
    }

    void OnTriggerEnter(Collider other)
    {
        Explosion();
        scoreManager.IncreaseScore(scoreToGive); //Increase score 
        Destroy(other.gameObject); // Destroy this game object (whatever the script is on)
        Destroy(gameObject); // Destroy other game object that passes trhough the trigger
       
    }

    public void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    }
   
}
