using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Balloon: MonoBehaviour
{

    public int clickToPop = 3;
    public float scaleToIncrease = 0.10f; //each time the ballon is clicked inflate 10%
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1; //reduce clics by one

        //inflate the balloon %10 every time it is clicked on
        transform.localScale += Vector3.one * scaleToIncrease;

        //check to see if clickToPop has reached zero.If it has then pop balloon
        if(clickToPop == 0)
        {
            Destroy(gameObject);
        }
    }
}
