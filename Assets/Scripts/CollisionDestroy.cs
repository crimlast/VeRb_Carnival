using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    // Static score tracker reference to avoid creating reference for each bullet instance
    private static bool isTrackerSet = false;

    private void Awake()
    {
        // Initialize score tracker reference if needed

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Destroy the target if hit
        if(collision.gameObject.tag == "Target")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject, 3);
        }

        // Destroy the bullet itself on colliding after 3 seconds
        
    }

    // Make score tracker reference null
    public static void NullifyScoreTracker()
    {
    }
}
