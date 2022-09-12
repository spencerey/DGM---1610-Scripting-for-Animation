using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Global variables
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;

    public float xRange = 5; 
    

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval); //Call spawnRandomBalloon function 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalloon()
    {
        //Get a random position on the x-axis
        Vector3 spawnPosX = new Vector3(Random.Range(-xRange, xRange), 0,0); 
        
        //Pick a random balloon from the balloon array
        int balloonIndex = Random.Range(0,balloonPrefabs.Length); //index declares one of the balloons

        //Spawn a random baloon at spawn point
        Instantiate(balloonPrefabs[balloonIndex], spawnPosX, balloonPrefabs[balloonIndex].transform.rotation);

    }
}
