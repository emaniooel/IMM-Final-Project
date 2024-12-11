using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManagerX : MonoBehaviour
{
    public GameObject flyingObstacle;

    private float spawnLimitXLeft = -11;  // Left limit for random spawn position along the x-axis
    private float spawnLimitXRight = 11;   // Right limit for random spawn position along the x-axis
    private float spawnPosY = 2;  
    private float spawnPosZ = 12; 


    private float startDelay = 1.0f;     
    private float spawnInterval = 1.7f; 

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
    }

    void SpawnObstacle()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, spawnPosZ);
        Instantiate(flyingObstacle, spawnPos, flyingObstacle.transform.rotation);
    }
}