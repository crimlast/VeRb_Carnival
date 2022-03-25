using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackandForthMove : MonoBehaviour
{
    public float MoveSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Moves the object forward at 5 units per second.
        transform.position = new Vector3 (Mathf.PingPong(Time.time * MoveSpeed, 2), transform.position.y, transform.position.z);

    }
}
