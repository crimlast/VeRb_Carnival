using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingScore : MonoBehaviour
{
    private int score;

    public TMPro.TextMeshPro scoreText;
    public int pointsPerPin;

    public void AddPoints()
    {
        score += pointsPerPin;
        UpdateScoreText();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
