using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TMP_Text textScore;
    public float score;


    // Start is called before the first frame update
    void Start()
    {
        
        textScore.text = score.ToString() + " Skull points ";
        score = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = " Skull points " +  score.ToString();
    }
}
