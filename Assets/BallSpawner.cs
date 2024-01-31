using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ballPrefab;
    public Transform spawnTransform; 
    
    void Start()
    {
        
        
        Vector3 spawnPosition = spawnTransform.position;
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 spawnPosition = spawnTransform.position;
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity); 
        }
    }
}
