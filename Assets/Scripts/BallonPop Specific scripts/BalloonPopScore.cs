using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BalloonPopScore : MonoBehaviour
{
    private int score;

    public TMP_Text scoreText;
    public int pointsPerPop;

    public void AddPoints()
    {
        score += pointsPerPop;
        UpdateScoreText();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = string.Format("Score: {000}", score);
    }
}
