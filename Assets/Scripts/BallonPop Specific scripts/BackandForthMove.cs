using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAndRight : MonoBehaviour
{
    float MoveSpeed;
    Vector3 pointA;
    Vector3 pointB;
    void Start()
    {
        MoveSpeed = Random.Range(0.2f, 1.5f);
        pointA = transform.position;
        pointB = new Vector3(transform.position.x, transform.position.y , transform.position.z + 2);
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the object forward at 5 units per second.
        float time = Mathf.PingPong(Time.time * MoveSpeed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
