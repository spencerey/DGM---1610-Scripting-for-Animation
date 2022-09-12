using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{

    public float moveSpeed; // Speed at which the balloon will move upwards
    public float upperBound; // Top boundary for when the balloon exits the screen it will get destroyed

    private Balloon balloon; // Reference to balloon game object

    // Start is called before the first frame update
    void Start()
    {
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
       //Move the balloon upwards
       transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

       //Destroy balloon if it reaches the top boundary, we do that with conditional statements
       if(transform.position.y > upperBound)
       {
            Destroy(gameObject);
       } 
    }
}
