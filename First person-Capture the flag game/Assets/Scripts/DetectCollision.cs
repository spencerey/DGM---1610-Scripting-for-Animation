using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   
    public ParticleSystem explosionParticle;

    
    // Update is called once per frame
    void OnTriggerEnter(Collider Other)

    {
        explosionParticle.Play();
    }    
     

    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, transform.rotation);
       
    }
}
