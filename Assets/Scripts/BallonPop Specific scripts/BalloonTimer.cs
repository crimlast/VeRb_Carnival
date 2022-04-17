using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BalloonTimer : MonoBehaviour
{
    private float time;
    private bool isTimerRunning = true;

    public TMP_Text textObject;
    public float startTimeSeconds;

    private void Start()
    {
        time = startTimeSeconds;
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            if (time > 0)
            {
                // Update the timer and display it
                time -= Time.deltaTime;
                DisplayTime();
            }
            else
            {
                // Keep timer at 0, and stop it
                time = 0;
                isTimerRunning = false;
            }
        }
    }

    // Display time left on UI
    private void DisplayTime()
    {
        // Only display time left based on curTime if it is above or equal to zero
        if (time >= 0)
        {
            // Caculate and format time to display it
            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time % 60);
            textObject.text = string.Format("Time Left: {0}:{1:00}", minutes, seconds);
        }
        else
        {
            textObject.text = "No more time left";
        }
    }
}
