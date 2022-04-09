using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingScore : MonoBehaviour
{
    private int score;

    public int pointsPerPin;

    public void AddPoints()
    {
        score += pointsPerPin;
        Debug.Log("Points added: " + pointsPerPin + " Total Score: " + score);
        // TODO: Update UI to reflect score
    }
}
