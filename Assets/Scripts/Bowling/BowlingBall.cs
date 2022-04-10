using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    private void Start()
    {
        SetBall();
    }

    private void SetBall()
    {
        ResetGame.SetBall(gameObject);
    }
}
