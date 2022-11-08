using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDropDown : MonoBehaviour
{

    private PlatformEffector2D effector2D;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        effector2D = GetComponent<PlatformEffector2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
        {
            waitTime = 0.5F;
        }

        //Flipping effector down
        if(Input.GetKey(KeyCode.S))//If wait time is reduced to zero to flip effector down
        {
            if(waitTime <= 0)
            {
                effector2D.rotationalOffset = 100f; //flips effector
                waitTime = 0.5f;// sets wait time
            }

            else
            {
                waitTime -= Time.deltaTime;//reduces waittime over time
            }
        }
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            effector2D.rotationalOffset = 0;
        }
    }
}
