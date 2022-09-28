using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
    
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Destroy this game object (whatever the script is on)
        Destroy(gameObject); // Destroy other game object that passes trhough the trigger

    }
   
}
