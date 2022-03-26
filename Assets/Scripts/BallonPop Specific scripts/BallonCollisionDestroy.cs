using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonCollisionDestroy : MonoBehaviour
{
    // Static score tracker reference to avoid creating reference for each bullet instance
    private static bool isTrackerSet = false;
    public GameObject molePrefab;
    private Vector3 spawnPos;

    private void Awake()
    {
        // Initialize score tracker reference if needed

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Destroy the target if hit
        if(collision.gameObject.tag == "Target")
        {
            // Destroys "target when collided with this object
            Destroy(collision.gameObject);

            //Spawns a screaming mole after target destruction on the same spot
            spawnPos = transform.position;
            molePrefab = Instantiate(molePrefab);
            molePrefab.transform.position = spawnPos;
            //Destroys the falling mole after 3 seconds.
            Destroy(gameObject, 3);
        }
        
    }

}
