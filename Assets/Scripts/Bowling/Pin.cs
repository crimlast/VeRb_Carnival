using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private static int totalPinsDown;
    private static int numPins;

    private BowlingScore scoreScript;
    private bool knockedDown;
    private int layerMask;
    private float distToGround;

    private void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<BowlingScore>();
        knockedDown = false;
        layerMask = LayerMask.GetMask("BowlingLane");
        distToGround = gameObject.GetComponent<Collider>().bounds.extents.y;

        AddPin();
    }

    private void Update()
    {
        if (!knockedDown && !Physics.Raycast(transform.position, -transform.up, distToGround + 0.1f, layerMask))
        {
            KnockDownPin();
            //Debug.Log(gameObject.name + " Fell");
        }
    }

    private void AddPin()
    {
        numPins++;
        ResetGame.AddPin(gameObject);
    }

    private void KnockDownPin()
    {
        totalPinsDown++;
        scoreScript.AddPoints();

        if (totalPinsDown >= numPins)
        {
            //Debug.Log("Won game");
        }
    }
}
