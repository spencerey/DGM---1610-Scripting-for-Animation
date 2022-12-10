using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   // private ScoreManager scoreManager;

    //public int scoreToGive;
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    /*void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }*/

    // Update is called once per frame
    void OnTriggerEnter(Collider Other)

    {
        explosionParticle.Play();
       // scoreManager.IncreaseScore(scoreToGive);
       //Destroy(other.gameObject);
       //Destroy(gameObject);   
    }

    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
    }
}
