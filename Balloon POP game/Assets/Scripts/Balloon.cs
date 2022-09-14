using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Balloon: MonoBehaviour
{

    public int clickToPop = 3;
    
    public float scaleToIncrease = 0.10f; //each time the ballon is clicked inflate 10%
    
    public int scoreToGive = 100;
    
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        //Reference gameobject and get score manager
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1; //reduce clics by one

        //inflate the balloon %10 every time it is clicked on
        transform.localScale += Vector3.one * scaleToIncrease;

        //check to see if clickToPop has reached zero.If it has then pop balloon
        if(clickToPop == 0)
        {
            //Send points to score manager and update the score
            scoreManager.IncreaseScoreText(scoreToGive);
            //Destroy balloon
            Destroy(gameObject);
        }
    }
}
