using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAndRight : MonoBehaviour
{
    float MoveSpeed;
    Vector3 pointA;
    Vector3 pointB;
    int x, y;
    void Start()
    {
        MoveSpeed = Random.Range(-0.8f, 1.5f);
        x = (int)Random.Range(-3, 3f);
        y = x = (int)Random.Range(-2, 4f);
        pointA = transform.position;
        pointB = new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the object forward at 5 units per second.
        float time = Mathf.PingPong(Time.time * MoveSpeed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);

    }
}
