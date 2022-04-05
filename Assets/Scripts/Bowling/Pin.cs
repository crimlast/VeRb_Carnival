using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private static int totalPinsDown;
    private static int numPins;

    private bool knockedDown;
    private int layerMask;
    private float distToGround;

    private void Start()
    {
        knockedDown = false;
        layerMask = LayerMask.GetMask("BowlingLane");
        distToGround = gameObject.GetComponent<Collider>().bounds.extents.y;

        numPins++;
    }

    private void Update()
    {
        if (!knockedDown && !Physics.Raycast(transform.position, -transform.up, distToGround + 0.1f, layerMask))
        {
            totalPinsDown++;
            Debug.Log(gameObject.name + " Fell");
        }
    }
}
